using System;
using System.Collections.Generic;
using System.Text;
using BSharp.Common;

namespace BSharp.Components
{
    public class PropertyBlock : FieldBlock
    {
        public MethodBlock Getter { get; set; }

        public MethodBlock Setter { get; set; }

        public PropertyBlock(string name, DynamicType type) : base(name, type)
        {
        }
    }
}
