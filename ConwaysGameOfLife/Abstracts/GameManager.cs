using ConwaysGameOfLife.Translators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Abstracts
{
    /// <summary>
    /// Represents the base class for game manager classes
    /// </summary>
    /// <typeparam name="TCell">The type of cells the manager has to manage</typeparam>
    public abstract class GameManager
    {
        protected int _generation;
        protected Frame _view;

        /// <summary>
        /// Initializes a new instance of <see cref="GameManager"/> class
        /// </summary>
        protected GameManager()
        {
        }

        public abstract int NextGeneration();

        protected abstract void InitUniverse();
    }
}
