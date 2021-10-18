using System.Reflection;
using System.Windows.Forms;

namespace ConwaysGameOfLife.Gui.Controls
{
    /// <summary>
    /// Represents a paintable control that supports double-buffering
    /// </summary>
    internal sealed class Painter : Control
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Painter"/> class
        /// </summary>
        public Painter() : base()
        {
            base.DoubleBuffered = true;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this control should redraw its surface using a secondary buffer to reduce or prevent flicker
        /// </summary>
        /// <returns><see langword="true"/> if the surface of the control should be drawn using double buffering; otherwise, <see langword="false"/></returns>
        public new bool DoubleBuffered
        {
            get => base.DoubleBuffered;
            set => base.DoubleBuffered = value;
        }
    }
}
