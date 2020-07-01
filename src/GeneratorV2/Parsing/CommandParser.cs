using GeneratorV2.Data;
using GeneratorV2.Extensions;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Xml.Linq;

namespace GeneratorV2.Parsing
{
    public class CommandParser : IParser<XElement>
    {
        private const string PlatformSpecificGlHandleArbFlag = "\x001A";

        public void Parse(XElement input, Specification output)
        {
            Logger.Info("Beggining parsing of commands.");
            var xelement = input.Element("commands");
            var commands = output.Commands;
            foreach (var element in xelement.Elements("command"))
            {
                var command = ParseCommand(element, out var isGLhandleArb);
                if (command != null)
                {
                    if (isGLhandleArb)
                    {
                        CreatePlatformSpecificGlHandleArb(commands, command);
                    }
                    else
                    {
                        commands.Add(command.Method.EntryPoint, command);
                    }
                }
            }
        }

        private static Command? ParseCommand(XElement c, out bool isGLhandleArb)
        {
            isGLhandleArb = false;
            var empty = string.Empty;
            try
            {
                var t = c.Element("proto");
                empty = t.Element("name").Value;
                var methodName = empty.Substring(2);
                var parameterList = new List<Parameter>();
                foreach (var element in c.Elements("param"))
                {
                    var paramName  = NameMangler.MangleParameterName(element.Element("name").Value);
                    var ptype = ParsePType(element);
                    isGLhandleArb |= ptype.Name == PlatformSpecificGlHandleArbFlag;
                    parameterList.Add(new Parameter(ptype, paramName ));
                }
                var ptype1 = ParsePType(t);
                isGLhandleArb |= ptype1.Name == PlatformSpecificGlHandleArbFlag;
                return new Command(new Method(ptype1, empty, parameterList.ToArray()), methodName);
            }
            catch (NullReferenceException)
            {
                Logger.Error("Error in parsing method \"" + empty + "\"");
                return null;
            }
        }

        private void CreatePlatformSpecificGlHandleArb(Dictionary<string, Command> coms, Command commandBase)
        {
            var method = commandBase.Method;
            var success = true;
            var appleMethodReturnType = ClonePType(method.ReturnType, "IntPtr");
            var otherMethodReturnType = ClonePType(method.ReturnType, "uint");
            var overloadMethodReturnType = ClonePType(method.ReturnType, "GLhandleARB");
            var appleParameters = new Parameter[method.Parameters.Length];
            var otherParameters = new Parameter[method.Parameters.Length];
            var overloadParameters = new Parameter[method.Parameters.Length];
            for (var index = 0; index < method.Parameters.Length; ++index)
            {
                var parameter = method.Parameters[index];
                var paramName = parameter.Name;
                appleParameters[index] = new Parameter(ClonePType(parameter.Type, "IntPtr"), paramName);
                otherParameters[index] = new Parameter(ClonePType(parameter.Type, "uint"), paramName);
                overloadParameters[index] = new Parameter(ClonePType(parameter.Type, "GLhandleARB"), paramName);
            }
            if (!success)
            {
                Logger.Error("Function " + commandBase.Name + " has a GLhandleARB* which is not passed correctly");
            }
            else
            {
                var apple = new Method(appleMethodReturnType, method.EntryPoint, appleParameters);
                var otherMethod = new Method(otherMethodReturnType, method.EntryPoint, otherParameters);
                Action<IndentedTextWriter, string> bodyWriter = (writer, commandName) =>
                {
                    writer.WriteLine("if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))");
                    using (writer.Scope())
                    {
                        if (method.EntryPoint == "glGetAttachedObjectsARB")
                        {
                            WriteGetAttachedObjects("__APPLE_", "IntPtr");
                        }
                        else
                        {
                            WriteCommand("__APPLE_");
                        }
                    }
                    writer.WriteLine("else");
                    using (writer.Scope())
                    {
                        if (otherMethod.EntryPoint == "glGetAttachedObjectsARB")
                        {
                            WriteGetAttachedObjects("__GOOD_", "uint");
                        }
                        else
                        {
                            WriteCommand("__GOOD_");
                        }
                    }

                    void WriteGetAttachedObjects(string name, string type)
                    {
                        writer.WriteLine(type + "* tmp = stackalloc " + type + "[maxCount];");
                        writer.WriteLine(name + commandName + "(containerObj, maxCount, count, tmp);");
                        writer.WriteLine("for (int i = 0; i < maxCount; i++)");
                        using (writer.Scope())
                        {
                            writer.WriteLine("obj[i] = tmp[i];");
                        }
                    }

                    void WriteCommand(string name)
                    {
                        if (commandBase.Method.ReturnType.Name != "void")
                        {
                            writer.Write("return ");
                        }
                        writer.Write(name + commandName + "(");
                        for (var index = 0; index < overloadParameters.Length; ++index)
                        {
                            writer.Write(overloadParameters[index].Name);
                            if (index != overloadParameters.Length - 1)
                            {
                                writer.Write(", ");
                            }
                        }
                        writer.WriteLine(");");
                    }
                };
                var baseOverload = new Overload(overloadMethodReturnType, bodyWriter, overloadParameters);
                coms.Add(method.EntryPoint, new HandleARBCommand(otherMethod, commandBase.Name, apple, baseOverload, null));
            }

            PType ClonePType(PType original, string newType)
            {
                if (!original.Name.StartsWith("\x001A"))
                {
                    return original;
                }
                if (original.Name.Length > "\x001A".Length && method.EntryPoint != "glGetAttachedObjectsARB")
                {
                    success = false;
                }
                return new PType(newType + original.Name.Substring(1), original.OriginalTypeName, original.Modifier, original.Group, original.Length);
            }
        }

        private static PType ParsePType(XElement t)
        {
            var group = t.Attribute("group")?.Value;
            var length = t.Attribute("len")?.Value;
            var str = t.GetXmlText(element => !(element.Name == "name") ? element.Value : string.Empty).Trim();
            var modifier = PModifier.None;
            return new PType(ParseType(str, ref modifier, ref length), str, modifier, group, length);
        }

        private static string ParseType(string type, ref PModifier modifier, ref string? length)
        {
            type = type.Trim();

            if (type.EndsWith(']'))
            {
                int openingBracketIndex = type.LastIndexOf('[');
                if (openingBracketIndex != -1)
                {
                    if (length != null)
                    {
                        throw new NotSupportedException("Nested array type parsing not supported!");
                    }


                    length = type.Substring(openingBracketIndex + 1, type.Length - openingBracketIndex - 2);
                    return ParseType(type.Substring(0, openingBracketIndex) + "*", ref modifier, ref length);
                }
            }

            if (type.EndsWith('*'))
            {
                return ParseType(type[0..^1], ref modifier, ref length) + "*";
            }

            if (type.EndsWith("const"))
            {
                modifier |= PModifier.ReadOnlySpan;
                return ParseType(type.Substring(0, type.Length - "const".Length), ref modifier, ref length);
            }

            if (type.StartsWith("const"))
            {
                modifier |= PModifier.In;
                return ParseType(type["const".Length..], ref modifier, ref length);
            }

            if (type.StartsWith("struct"))
            {
                type = type["struct".Length..].Trim();
            }

            var t = type switch
            {
                "void" => "void",
                "GLenum" => "uint",
                "GLboolean" => "byte",
                "GLbitfield" => "uint",
                "GLvoid" => "void",
                "GLbyte" => "sbyte",
                "GLubyte" => "byte",
                "GLshort" => "short",
                "GLushort" => "ushort",
                "GLint" => "int",
                "GLuint" => "uint",
                "GLclampx" => "int",
                "GLsizei" => "int",
                "GLfloat" => "float",
                "GLclampf" => "float",
                "GLdouble" => "double",
                "GLclampd" => "double",
                "GLeglClientBufferEXT" => "void*",
                "GLeglImageOES" => "void*",
                "GLchar" => "char",
                "GLcharARB" => "char",
                "GLhalf" => "short",
                "GLhalfARB" => "short",
                "GLfixed" => "int",
                "GLintptr" => "IntPtr",
                "GLintptrARB" => "IntPtr",
                "GLsizeiptr" => "IntPtr",
                "GLsizeiptrARB" => "IntPtr",
                "GLint64" => "int",
                "GLint64EXT" => "int",
                "GLuint64" => "uint",
                "GLuint64EXT" => "uint",
                "GLhalfNV" => "ushort",
                "GLvdpauSurfaceNV" => "IntPtr",
                "GLVULKANPROCNV" => "void",
                "GLhandleARB" => PlatformSpecificGlHandleArbFlag, //This type is platform specific on apple.

                //The following have a custom c# implementation in the writer.
                "GLsync" => "GLsync*",
                "_cl_context" => "CLContext",
                "_cl_event" => "CLEvent",
                "GLDEBUGPROC" => "GLDEBUGPROC",
                "GLDEBUGPROCARB" => "GLDEBUGPROCARB",
                "GLDEBUGPROCKHR" => "GLDEBUGPROCKHR",
                "GLDEBUGPROCAMD" => "GLDEBUGPROCAMD",
                "GLDEBUGPROCNV" => "GLDEBUGPROCNV",
                _ => null
            };

            if (t == null)
            {
                Logger.Error($"Type conversion has not been created for type {type}");
                return type;
            }

            return t;
        }
    }
}