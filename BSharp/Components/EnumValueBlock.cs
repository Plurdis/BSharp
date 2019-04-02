using System;
using System.Collections.Generic;
using System.Text;
using BSharp.Common;
using BSharp.Extensions;

namespace BSharp.Components
{
    public class EnumValueBlock : FieldBlock
    {
        public IBlock Value { get; set; }

        public EnumValueBlock(string name, DynamicType type) : base(name, type)
        {
        }

        public EnumValueBlock(string name, IBlock value) : base(name, typeof(int).ToDynamic())
        {
            Value = value;
        }
    }
}
