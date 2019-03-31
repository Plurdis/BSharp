using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class ConstructorBlock : MethodBlock
    {
        public override string Name
        {
            get => ".ctor";
            set { }
        }

        public ClassBlock ClassBlock { get; }

        internal ConstructorBlock(ClassBlock classBlock)
        {
            ClassBlock = classBlock;
        }
    }
}
