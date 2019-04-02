using System;
using System.Collections.Generic;
using System.Text;
using BSharp.Common;

namespace BSharp.Components
{
    public class EnumValueBlock : FieldBlock
    {
        public IBlock Value { get; set; }

        public EnumValueBlock(string name, DynamicType type) : base(name, type)
        {
        }
    }
}
