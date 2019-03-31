using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Components
{
    public class IfBlock : BlockGroupBase
    {
        public IBlock Condition { get; set; }
    }
}
