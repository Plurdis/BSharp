using BSharp.Common;
using BSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp
{
    public class ValueBlock : BlockBase
    {
        public DynamicType ValueType { get; set; }

        public virtual object Value { get; set; }

        public ValueBlock()
        {

        }

        public ValueBlock(object value)
        {
            Value = value;
            ValueType = value?.GetType()?.ToDynamic();
        }

        public ValueBlock(object value, DynamicType type)
        {
            Value = value;
            ValueType = type;
        }
    }
}
