using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the base interface for patterns
    /// </summary>
    public interface IPattern
    {
        /// <summary>
        /// Represents the name of the specific pattern
        /// </summary>
        public string Name { get; }
    }
}
