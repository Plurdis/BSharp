using BSharp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class FieldBlock : BlockBase
    {
        public string Name { get; set; }

        public DynamicType Type { get; set; }

        public bool IsStatic { get; set; }

        public FieldBlock(string name, DynamicType type)
        {
            Name = name;
            Type = type;
        }
    }
}
