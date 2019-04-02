using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp
{
    public interface IBlock
    {
        string Id { get; }

        IBlockInfo BlockInfo { get; }

        IBlock Parent { get; }
         
        bool HasParent { get; }
    }
}
