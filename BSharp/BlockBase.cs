using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp
{
    public abstract class BlockBase : IBlock
    {
        public string Id { get; set; }

        public abstract IBlockInfo BlockInfo { get; }

        public IBlock Parent { get; set; }

        public bool HasParent => Parent != null;
    }
}
