using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp
{
    public interface IGroupBlock : IBlock
    {
        IEnumerable<IBlock> Nodes { get; }

        int Count { get; }

        void Add(IBlock block);

        void Remove(IBlock block);

        void RemoveAt(int index);

        int IndexOf(IBlock block);
        
        IEnumerable<IBlock> FindById(string id);
    }
}
