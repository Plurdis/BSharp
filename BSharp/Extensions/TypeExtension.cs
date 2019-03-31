using BSharp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Extensions
{
    public static class TypeExtension
    {
        public static DynamicType ToDynamic(this Type type)
        {
            return new DynamicType(type);
        }
    }
}
