using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Generator
{
    public abstract class BaseGenerator : IGenerator
    {
        protected virtual bool CheckIf(IBlock block)
        {
            return true;
        }

        public abstract string Convert(IEnumerable<IBlock> blocks);

        public abstract string Convert(IBlock block);
    }
}
