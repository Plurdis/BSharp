using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class CallerBlock : BlockBase
    {
        public IBlock Target { get; set; }

        public MethodBlock Method { get; set; }

        public CallerBlock(IBlock target, MethodBlock method)
        {
            Target = target;
            Method = method;
        }
    }
}
