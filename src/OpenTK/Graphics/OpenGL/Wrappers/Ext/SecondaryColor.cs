//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Text;
using System.Runtime.InteropServices;

namespace OpenTK.Graphics.OpenGL
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "SecondaryColor" in the extension "Ext".
        /// </summary>
        public static partial class Ext
        {
            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3bEXT")]
            public static void SecondaryColor3(SByte red, SByte green, SByte blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3bvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] SByte[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3bvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref SByte v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3dEXT")]
            public static void SecondaryColor3(double red, double green, double blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3dvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] double[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3dvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref double v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3fEXT")]
            public static void SecondaryColor3(float red, float green, float blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3fvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3fvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3iEXT")]
            public static void SecondaryColor3(int red, int green, int blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3ivEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] int[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3ivEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref int v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3sEXT")]
            public static void SecondaryColor3(short red, short green, short blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3svEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] short[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3svEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref short v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3ubEXT")]
            public static void SecondaryColor3(Byte red, Byte green, Byte blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3ubvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] Byte[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3ubvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref Byte v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3uiEXT")]
            public static void SecondaryColor3(uint red, uint green, uint blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3uivEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] uint[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3uivEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref uint v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="red">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="green">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            /// <param name="blue">
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3usEXT")]
            public static void SecondaryColor3(ushort red, ushort green, ushort blue)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3usvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ushort[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Set the current secondary color
            /// </summary>
            /// <param name="v">
            /// [length: 3]
            /// Specify new red, green, and blue values for the current secondary color.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColor3usvEXT")]
            public static void SecondaryColor3([CountAttribute(Count = 3)] ref ushort v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Define an array of secondary colors
            /// </summary>
            /// <param name="size">
            /// Specifies the number of components per color. Must be 3.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, or Double are accepted. The initial value is Float.
            /// </param>
            /// <param name="stride">
            /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(size,type,stride)]
            /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColorPointerEXT")]
            public static void SecondaryColorPointer(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [CountAttribute(Computed = "size,type,stride")] IntPtr pointer)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Define an array of secondary colors
            /// </summary>
            /// <param name="size">
            /// Specifies the number of components per color. Must be 3.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, or Double are accepted. The initial value is Float.
            /// </param>
            /// <param name="stride">
            /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(size,type,stride)]
            /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColorPointerEXT")]
            public static void SecondaryColorPointer<T3>(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [InAttribute, OutAttribute, CountAttribute(Computed = "size,type,stride")] T3[] pointer)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Define an array of secondary colors
            /// </summary>
            /// <param name="size">
            /// Specifies the number of components per color. Must be 3.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, or Double are accepted. The initial value is Float.
            /// </param>
            /// <param name="stride">
            /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(size,type,stride)]
            /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColorPointerEXT")]
            public static void SecondaryColorPointer<T3>(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [InAttribute, OutAttribute, CountAttribute(Computed = "size,type,stride")] T3[,] pointer)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Define an array of secondary colors
            /// </summary>
            /// <param name="size">
            /// Specifies the number of components per color. Must be 3.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, or Double are accepted. The initial value is Float.
            /// </param>
            /// <param name="stride">
            /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(size,type,stride)]
            /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColorPointerEXT")]
            public static void SecondaryColorPointer<T3>(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [InAttribute, OutAttribute, CountAttribute(Computed = "size,type,stride")] T3[,,] pointer)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: EXT_secondary_color]
            /// Define an array of secondary colors
            /// </summary>
            /// <param name="size">
            /// Specifies the number of components per color. Must be 3.
            /// </param>
            /// <param name="type">
            /// Specifies the data type of each color component in the array. Symbolic constants Byte, UnsignedByte, Short, UnsignedShort, Int, UnsignedInt, Float, or Double are accepted. The initial value is Float.
            /// </param>
            /// <param name="stride">
            /// Specifies the byte offset between consecutive colors. If stride is 0, the colors are understood to be tightly packed in the array. The initial value is 0.
            /// </param>
            /// <param name="pointer">
            /// [length: COMPSIZE(size,type,stride)]
            /// Specifies a pointer to the first component of the first color element in the array. The initial value is 0.
            /// </param>
            [AutoGenerated(Category = "EXT_secondary_color", Version = "", EntryPoint = "glSecondaryColorPointerEXT")]
            public static void SecondaryColorPointer<T3>(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [InAttribute, OutAttribute, CountAttribute(Computed = "size,type,stride")] ref T3 pointer)
                where T3 : struct
            {
                throw new BindingsNotRewrittenException();
            }

            [Slot(2049)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3bEXT(SByte red, SByte green, SByte blue);

            [Slot(2051)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3bvEXT([CountAttribute(Count = 3)] SByte* v);

            [Slot(2053)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3dEXT(double red, double green, double blue);

            [Slot(2055)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3dvEXT([CountAttribute(Count = 3)] double* v);

            [Slot(2057)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3fEXT(float red, float green, float blue);

            [Slot(2059)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3fvEXT([CountAttribute(Count = 3)] float* v);

            [Slot(2063)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3iEXT(int red, int green, int blue);

            [Slot(2065)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3ivEXT([CountAttribute(Count = 3)] int* v);

            [Slot(2067)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3sEXT(short red, short green, short blue);

            [Slot(2069)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3svEXT([CountAttribute(Count = 3)] short* v);

            [Slot(2071)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3ubEXT(Byte red, Byte green, Byte blue);

            [Slot(2073)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3ubvEXT([CountAttribute(Count = 3)] Byte* v);

            [Slot(2075)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3uiEXT(uint red, uint green, uint blue);

            [Slot(2077)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3uivEXT([CountAttribute(Count = 3)] uint* v);

            [Slot(2079)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue);

            [Slot(2081)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glSecondaryColor3usvEXT([CountAttribute(Count = 3)] ushort* v);

            [Slot(2086)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glSecondaryColorPointerEXT(int size, OpenTK.Graphics.OpenGL.ColorPointerType type, int stride, [CountAttribute(Computed = "size,type,stride")] IntPtr pointer);
        }
    }
}