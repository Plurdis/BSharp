using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class ReturnBlock : BlockGroupBase
    {
        public ReturnBlock()
        {

        }

        public ReturnBlock(IBlock value)
        {
            Add(value);
        }

        public override void Add(IBlock block)
        {
            if (InternalNodes.Count == 1)
                InternalNodes[0] = block;
            else
                InternalNodes.Add(block);
        }
    }
}
