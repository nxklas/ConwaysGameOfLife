using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents a custom pattern
    /// </summary>
    public sealed class CustomPattern : Pattern2D
    {
        private string _name;

        /// <summary>
        /// Initializes a new instance of <see cref="CustomPattern"/> class
        /// </summary>
        public CustomPattern(string name) : base(null)
        {
            _name = name;
        }

        /// <summary>
        /// Represents the name of the custom pattern
        /// </summary>
        public override string Name => _name;
    }
}
