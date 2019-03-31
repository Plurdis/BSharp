using System;
using System.Collections.Generic;
using System.Text;

namespace BSharp.Common
{
    public enum OperationType
    {
        /// <summary>
        /// ==
        /// </summary>
        Equal,

        /// <summary>
        /// !=
        /// </summary>
        NotEqual,

        /// <summary>
        /// >
        /// </summary>
        GreaterThan,

        /// <summary>
        /// &lt;
        /// </summary>
        LessThan,

        /// <summary>
        /// >=
        /// </summary>
        GreaterThanEqual,

        /// <summary>
        /// &lt;=
        /// </summary>
        LessThenEqual,

        /// <summary>
        /// |
        /// </summary>
        Or,

        /// <summary>
        /// ||
        /// </summary>
        OrElse,

        /// <summary>
        /// &amp;
        /// </summary>
        And,

        /// <summary>
        /// &amp;&amp;
        /// </summary>
        AndElse,

        /// <summary>
        /// ^
        /// </summary>
        XOr,

        /// <summary>
        /// +
        /// </summary>
        Plus,

        /// <summary>
        /// -
        /// </summary>
        Minus,

        /// <summary>
        /// *
        /// </summary>
        Multiply,

        /// <summary>
        /// /
        /// </summary>
        Divide,

        /// <summary>
        /// %
        /// </summary>
        Mod,
    }
}
