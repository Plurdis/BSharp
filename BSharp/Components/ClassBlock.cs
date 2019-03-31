using BSharp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BSharp.Components
{
    public class ClassBlock : BlockGroupBase
    {
        public string Name { get; set; }
        
        public IEnumerable<MethodBlock> Methods => InternalNodes
            .Where(e => e is MethodBlock)
            .Cast<MethodBlock>();

        public IEnumerable<FieldBlock> Fields => InternalNodes
            .Where(e => e is FieldBlock)
            .Cast<FieldBlock>();

        public IEnumerable<PropertyBlock> Properties => InternalNodes
            .Where(e => e is PropertyBlock)
            .Cast<PropertyBlock>();

        public IEnumerable<EventBlock> Events => InternalNodes
            .Where(e => e is EventBlock)
            .Cast<EventBlock>();

        public IEnumerable<ConstructorBlock> Constructors => InternalNodes
            .Where(e => e is ConstructorBlock)
            .Cast<ConstructorBlock>();

        public ClassBlock()
        {
            AddMethod(new ConstructorBlock(this));
        }
        
        public void AddMethod(MethodBlock block) => Add(block);

        public void AddField(FieldBlock block) => Add(block);

        public void AddProperty(PropertyBlock block) => Add(block);

        public void AddEvent(EventBlock block) => Add(block);

        public void RemoveMethod(MethodBlock block) => Remove(block);

        public void RemoveField(FieldBlock block) => Remove(block);

        public void RemoveProperty(PropertyBlock block) => Remove(block);

        public void RemoveEvent(EventBlock block) => Remove(block);

        public ConstructorBlock CreateConstructor(params FieldBlock[] parameters)
        {
            var ctorBlock = new ConstructorBlock(this)
            {
                Parameters = parameters
            };

            Add(ctorBlock);

            return ctorBlock;
        }

        public override void Add(IBlock block)
        {
            if ((block is MethodBlock) || (block is FieldBlock) ||
                (block is PropertyBlock) || (block is EventBlock))
            {
                InternalNodes.Add(block);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        public override void Remove(IBlock block)
        {
            int index = InternalNodes.IndexOf(block);

            if (index >= 0)
                InternalNodes.RemoveAt(index);
        }
    }
}
