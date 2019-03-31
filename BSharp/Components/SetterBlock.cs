using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    /// <summary>
    /// 값을 대입할 수 있는 블럭
    /// </summary>
    public class SetterBlock : BlockBase
    {
        public IBlock Target { get; set; }

        public IBlock Value { get; set; }
    }
}
