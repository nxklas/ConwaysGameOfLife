using ConwaysGameOfLife.Abstracts;
using ConwaysGameOfLife.Patterns;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace ConwaysGameOfLife
{
    /// <summary>
    /// Represents the manager for Conway's Game of Life
    /// </summary>
    public sealed class GameManager2D : GameManager
    {
        private const int CellsX = 999;
        private const int CellsY = 999;
        private double _scaleMultiplicand = 0.1;
        private double _scale = 1;
        private Universe2D _universe;

        /// <summary>
        /// Initializes a new instance of <see cref="GameManager2D"/> class
        /// </summary>
        public GameManager2D(int width, int heigth) : base()
        {
            _universe = new Universe2D(CellsX, CellsY);
            width /= Cell2D.Width;
            heigth /= Cell2D.Heigth;
            _view = new(width, heigth, GetViewsCenteredX(width), GetViewsCenteredY(heigth));
            InitUniverse();
        }

        /// <summary>
        /// Initializes the universe
        /// </summary>
        protected override void InitUniverse()
        {
            for (int x = 0; x < CellsX; x++)
                for (int y = 0; y < CellsY; y++)
                    _universe[x, y] = false;
        }

        public void ScaleDown()
        {
            _scale -= _scaleMultiplicand;
        }

        public void ScaleUp()
        {
            _scale += _scaleMultiplicand;
        }

        public IEnumerable<string> GetNativePatternNames()
        {
            IList<string> names = new List<string>();

            foreach (Type type in typeof(Pattern2D).Assembly.GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Pattern2D))))
                if (!type.Equals(typeof(CustomPattern)))
                    names.Add(((Pattern2D)Activator.CreateInstance(type, null)).Name);
            return names;
        }

        public void SetPattern(Pattern2D pattern)
        {
            for (int x = 0; x < pattern.Cells.GetLength(1); x++)
                for (int y = 0; y < pattern.Cells.GetLength(0); y++)
                    if (pattern.Cells[y, x] == 1)
                        _universe[x + (pattern.OffsetX / Cell2D.Width) + _view.X, y + (pattern.OffsetY / Cell2D.Heigth) + _view.Y] = true;
        }

        public Pattern2D GetPattern(string name)
        {
            foreach (Type type in typeof(Pattern2D).Assembly.GetTypes()
          .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(Pattern2D))))
                if (!type.Equals(typeof(CustomPattern)))
                {
                    Pattern2D p = (Pattern2D)Activator.CreateInstance(type, null);
                    if (p.Name == name)
                        return p;
                }
            return null;
        }

        /// <summary>
        /// Initializes the specified pattern <typeparamref name="TPattern"/> and adds it to the playground
        /// </summary>
        /// <typeparam name="TPattern">The type of the pattern to initialize</typeparam>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        public void InitPattern<TPattern>(int offsetX, int offsetY, bool inFrame = true) where TPattern : Pattern2D
        {
            TPattern pattern = typeof(TPattern).Assembly.CreateInstance(typeof(TPattern).FullName) as TPattern;

            for (int x = 0; x < pattern.Cells.GetLength(1); x++)
                for (int y = 0; y < pattern.Cells.GetLength(0); y++)
                    if (pattern.Cells[y, x] == 1)
                        if (inFrame)
                            _universe[x + offsetX + _view.X, y + offsetY + _view.Y] = true;
                        else
                            _universe[x + offsetX, y + offsetY] = true;
        }

        /// <summary>
        /// Lets every cell on the playground age
        /// </summary>
        /// <remarks>The part of the game which brings the game to life.
        /// <br>Algorithm must have to run over the complete universe each generation</br></remarks>
        public override int NextGeneration()
        {
            IList<Point> willDie = new List<Point>();
            IList<Point> willBear = new List<Point>();

            for (int x = 0; x < CellsX; x++)
                for (int y = 0; y < CellsY; y++)
                {
                    bool xIncreaseable = false;
                    bool xDecreaseable = false;
                    bool yIncreaseable = false;
                    bool yDecreaseable = false;
                    int neighbours = 0;
                    int len = _universe.GetLength(0) - 1;

                    //Checks for in- and decreasability of specific cell
                    if (len >= x + 1)
                        xIncreaseable = true;
                    if (0 <= x - 1)
                        xDecreaseable = true;

                    len = _universe.GetLength(1) - 1;

                    if (len >= y + 1)
                        yIncreaseable = true;
                    if (0 <= y - 1)
                        yDecreaseable = true;

                    //Counts neighbours of specific cell
                    if (xIncreaseable)
                        if (_universe[x + 1, y])
                            neighbours++;
                    if (xDecreaseable)
                        if (_universe[x - 1, y])
                            neighbours++;
                    if (yIncreaseable)
                        if (_universe[x, y + 1])
                            neighbours++;
                    if (yDecreaseable)
                        if (_universe[x, y - 1])
                            neighbours++;
                    if (xIncreaseable && yIncreaseable)
                        if (_universe[x + 1, y + 1])
                            neighbours++;
                    if (xIncreaseable && yDecreaseable)
                        if (_universe[x + 1, y - 1])
                            neighbours++;
                    if (xDecreaseable && yDecreaseable)
                        if (_universe[x - 1, y - 1])
                            neighbours++;
                    if (xDecreaseable && yIncreaseable)
                        if (_universe[x - 1, y + 1])
                            neighbours++;

                    //Analyzes if specific cell bears or dies
                    if (neighbours == 3 && !_universe[x, y])
                        willBear.Add(new Point(x, y));

                    if (neighbours < 2 || neighbours > 3)
                        if (_universe[x, y])
                            willDie.Add(new Point(x, y));
                }

            //Bears or kills analyzed cells
            foreach (Point current in willDie)
                _universe[current.X, current.Y] = false;
            foreach (Point current in willBear)
                _universe[current.X, current.Y] = true;

            return _generation++;
        }

        /// <summary>
        /// Gets an enumeration of every cell in the current view
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Cell2D"/>s which represents every cell in the current view</returns>
        public IEnumerable<Cell2D> GetItems()
        {
            IList<Cell2D> items = new List<Cell2D>();

            for (double x = _view.X; x < _view.X + _view.Width/_scale; x++)
                for (double y = _view.Y; y < _view.Y + _view.Height/_scale; y++)
                {
                    double relativeX = (x - _view.X) * (Cell2D.Width * _scale);
                    double relativeY = (y - _view.Y) * (Cell2D.Heigth * _scale);

                    //int relativeX = (x - _view.X) * Cell2D.Width;
                    //int relativeY = (y - _view.Y) * Cell2D.Heigth;

                    items.Add(new Cell2D(new Point((int)relativeX, (int)relativeY), _universe[(int)x, (int)y] ? CellState.Alive : CellState.Dead));
                }

            return items;
        }

        public void Resize(int width, int height)
        {
            width /= Cell2D.Width;
            height /= Cell2D.Heigth;

            int x = width - _view.Width;
            int y = height - _view.Height;

            _view.Resize(width, height);
            _view.Set(_view.X - x, _view.Y - y);
        }

        private void CenterView() => _view.Set(GetViewsCenteredX(_view.Width), GetViewsCenteredY(_view.Height));

        private int GetViewsCenteredX(int width) => (_universe.GetLength(0) / 2) - (width / 2);

        private int GetViewsCenteredY(int height) => (_universe.GetLength(1) / 2) - (height / 2);
    }
}
