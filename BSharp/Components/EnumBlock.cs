using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class EnumBlock : BlockGroupBase
    {
        public string Name { get; set; }

        public EnumBlock()
        {
        }

        public EnumBlock(string name)
        {
            Name = name;
        }

        public void AddField(EnumValueBlock block) => Add(block);

        public override void Add(IBlock block)
        {
            if (block is EnumValueBlock)
            {
                InternalNodes.Add(block);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
