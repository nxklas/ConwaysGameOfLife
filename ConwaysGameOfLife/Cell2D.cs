using ConwaysGameOfLife.Abstracts;
using System.Drawing;

namespace ConwaysGameOfLife
{
    /// <summary>
    /// Represents a <see cref="Cell"/> in a 2-dimensional space
    /// </summary>
    public sealed class Cell2D : Cell, IDrawable2D
    {
        /// <summary>
        /// Represents a standardized width for <see cref="Cell2D"/> instances
        /// </summary>
        public const int Width = 20;
        /// <summary>
        /// Represents a standardized heigth for <see cref="Cell2D"/> instances
        /// </summary>
        public const int Heigth = 20;

        private readonly Point _position;

        /// <summary>
        /// Initializes a new instance of <see cref="Cell2D"/> class which is dead
        /// </summary>
        /// <param name="x">The x-coordinate on the playground</param>
        /// <param name="y">The y-coordinate on the playground</param>
        public Cell2D(int x, int y) : this(x, y, CellState.Dead)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Cell2D"/> class and sets it's state (alive / dead)
        /// </summary>
        /// <param name="x">The x-coordinate on the playground</param>
        /// <param name="y">The y-coordinate on the playground</param>
        /// <param name="state">Indicates the state of the cell (alive / dead)</param>
        public Cell2D(int x, int y, CellState state) : base(state)
        {
            _position = new Point(x, y);
        }

        /// <summary>
        /// Draws the current cell
        /// </summary>
        /// <param name="graphics">The graphics used to paint</param>
        public void Draw(Graphics graphics)
        {
            graphics.FillRectangle(GetsInspected ? Brushes.Blue : IsAlive ? Brushes.Green : Brushes.Black, _position.X, _position.Y, Width, Heigth);
            graphics.DrawRectangle(new Pen(Color.White),_position.X,_position.Y,Width,Heigth);
        }
    }
}
