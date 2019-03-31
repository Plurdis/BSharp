using BSharp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    /// <summary>
    /// 메소드를 선언하고 사용하는 블럭입니다.
    /// </summary>
    public class MethodBlock : BlockGroupBase
    {
        public virtual string Name { get; set; }

        public FieldBlock[] Parameters { get; set; }

        public DynamicType ReturnType { get; set; }

        public bool IsStatic { get; set; }

        public MethodBlock()
        {

        }

        public MethodBlock(string name)
        {
            Name = name;
        }
    }
}
