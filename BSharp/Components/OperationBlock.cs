using BSharp.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class OperationBlock : BlockBase
    {
        public OperationType OperationType { get; set; } //TODO: Create EnumBlock

        public IBlock LeftBlock { get; set; }

        public IBlock RightBlock { get; set; }

        public OperationBlock()
        {

        }

        public OperationBlock(IBlock left, OperationType operation, IBlock right)
        {
            LeftBlock = left;
            OperationType = operation;
            RightBlock = right;
        }
    }
}
