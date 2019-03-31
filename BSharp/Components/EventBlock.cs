using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    /// <summary>
    /// 이벤트를 선언하고 사용하는 블럭입니다. (Nodes: 사용)
    /// </summary>
    public class EventBlock : BlockGroupBase
    {
        public string Name { get; set; }

        public FieldBlock[] Parameters { get; set; }

        public bool IsStatic { get; set; }
    }
}
