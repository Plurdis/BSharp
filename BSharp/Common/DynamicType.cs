using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Common
{
    public class DynamicType
    {
        public Type Type { get; }

        public string QualifiedTypeName { get; }

        public bool IsKnownType => Type != null;

        public DynamicType(string typeString)
        {
            QualifiedTypeName = typeString;
        }

        public DynamicType(Type type)
        {
            Type = type;
        }
    }
}
