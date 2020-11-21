using GeneratorV2.Extensions;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace GeneratorV2.Writing
{
    public class NamespaceNode : TypeContainerNode
    {
        private readonly string _name;

        public NamespaceNode(string name)
        {
            _name = name;
        }

        protected override void WriteDeclaration()
        {
            Writer.WriteLine("using System;");
            Writer.WriteLine("using System.Runtime.InteropServices;");
            Writer.WriteLine("using OpenTK.Graphics.Types;");
            Writer.WriteLine("using OpenTK.Core.Native;");
            Writer.WriteLine("using OpenTK.Mathematics;");
            Writer.WriteLine();
            Writer.WriteLine("namespace " + _name);
        }
    }
}
