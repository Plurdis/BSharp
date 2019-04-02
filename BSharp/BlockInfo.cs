using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp
{
    public abstract class BlockInfo : IBlockInfo
    {
        public IBlockInfo BaseInfo { get; }

        public string Name { get; }
    }
}
