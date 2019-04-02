using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BSharp
{
    public abstract class BlockGroupBase : IGroupBlock
    {
        public string Id { get; }

        public IBlock Parent { get; set; }

        public bool HasParent => Parent != null;

        public virtual IEnumerable<IBlock> Nodes => InternalNodes;

        public virtual int Count => InternalNodes.Count;

        internal List<IBlock> InternalNodes { get; }

        public abstract IBlockInfo BlockInfo { get; }

        public BlockGroupBase()
        {
            InternalNodes = new List<IBlock>();
        }

        public virtual IEnumerable<IBlock> FindById(string id)
        {
            if (Id == id)
                yield return this;

            foreach (IBlock block in Nodes.Where(i => i.Id == id))
                yield return block;
        }

        public virtual void Add(IBlock block)
        {
            InternalNodes.Add(block);
        }

        public virtual void Remove(IBlock block)
        {
            InternalNodes.Add(block);
        }

        public virtual void RemoveAt(int index)
        {
            InternalNodes.RemoveAt(index);
        }

        public virtual int IndexOf(IBlock block)
        {
            return InternalNodes.IndexOf(block);
        }
        
    }
}
