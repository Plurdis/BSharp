using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class GetterBlock : BlockBase
    {
        public IBlock Target { get; }

        public IBlock Member { get; }

        public GetterBlock()
        {
        }

        public GetterBlock(IBlock target, IBlock member)
        {
            Target = target;
            Member = member;
        }
    }
}
