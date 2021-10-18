using System.Drawing;

namespace ConwaysGameOfLife.Translators
{
    public struct Frame
    {
        private int _width;
        private int _height;
        private Point _location;

        public Frame(int width, int height) : this(width, height, 0)
        {
        }

        public Frame(int width, int height, int position) : this(width, height, position, position)
        {
        }

        public Frame(int width, int height, int positionX, int positionY)
        {
            _width = width;
            _height = height;
            _location = new(positionX, positionY);
        }

        public int Width => _width;
        public int Height => _height;

        public int X => _location.X;
        public int Y => _location.Y;

        public void Set(int position) => Set(position, position);

        public void Set(int positionX, int positionY)
        {
            _location = new(positionX, positionY);
        }

        public void Resize(int width, int height)
        {
            _width = width;
            _height = height;
        }
    }
}
