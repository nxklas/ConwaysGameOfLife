using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife.Translators
{
    public sealed class Translator2D
    {
        private static readonly Translator2D Current;

        static Translator2D()
        {
            Current = new();
        }

        private Translator2D() : base()
        {
        }

        public static Translator2D Get() => Current;

        public void AddPattern(ITranslateable pattern)
        {

        }

        public Point Translate(Point location,Frame frame, int indexX, int indexY)
        {
            return new Point();
        }
    }
}
