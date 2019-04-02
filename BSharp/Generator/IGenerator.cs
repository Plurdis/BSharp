using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Generator
{
    public interface IGenerator
    {
        string Convert(IEnumerable<IBlock> blocks);

        string Convert(IBlock block);
    }
}
