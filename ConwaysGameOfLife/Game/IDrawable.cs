using System.Drawing;

namespace ConwaysGameOfLife.Game
{
    /// <summary>
    /// Represents an interface for drawable objects
    /// </summary>
    internal interface IDrawable
    {
        /// <summary>
        /// Draws the current object
        /// </summary>
        /// <param name="graphics">The graphics used to paint</param>
        public void Draw(Graphics graphics);
    }
}
