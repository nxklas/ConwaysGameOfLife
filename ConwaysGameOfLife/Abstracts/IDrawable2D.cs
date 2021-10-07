using System.Drawing;

namespace ConwaysGameOfLife.Abstracts
{
    /// <summary>
    /// Represents an interface for drawable objects
    /// </summary>
    public interface IDrawable2D
    {
        /// <summary>
        /// Draws the current object
        /// </summary>
        /// <param name="graphics">The graphics used to paint</param>
        public void Draw(Graphics graphics);
    }
}
