using ConwaysGameOfLife.Patterns;
using System.Collections.Generic;
using System.Drawing;

namespace ConwaysGameOfLife
{
    /// <summary>
    /// Represents the manager for Conway's Game of Life
    /// </summary>
    public sealed class GameManager2D
    {
        private const int CellsX = 75;
        private const int CellsY = 75;
        private Cell2D[,] _playground;
        private int _generation;

        /// <summary>
        /// Initializes a new instance of <see cref="GameManager2D"/> class
        /// </summary>
        public GameManager2D()
        {
            _playground = new Cell2D[CellsX, CellsY];
            _generation = 0;
            InitPlayground();
        }

        /// <summary>
        /// Initializes the playground
        /// </summary>
        private void InitPlayground()
        {
            for (int x = 0; x < CellsX; x++)
            {
                for (int y = 0; y < CellsY; y++)
                {
                    _playground[x, y] = new Cell2D(x * Cell2D.Width, y * Cell2D.Heigth);
                }
            }

            InitPattern<TTetromino>(10, 10);
            InitPattern<TTetromino>(15, 10);
        }

        //TODO: add bounds and handle them (if figure goes out of them)

        /// <summary>
        /// Initializes the specified pattern <typeparamref name="TPattern"/> and adds it to the playground
        /// </summary>
        /// <typeparam name="TPattern">The type of the pattern to initialize</typeparam>
        /// <param name="offsetX"></param>
        /// <param name="offsetY"></param>
        public void InitPattern<TPattern>(int offsetX, int offsetY) where TPattern : Pattern2D
        {
            TPattern pattern = typeof(TPattern).Assembly.CreateInstance(typeof(TPattern).FullName) as TPattern;

            for (int x = 0; x < pattern.Cells.GetLength(0); x++)
            {
                for (int y = 0; y < pattern.Cells.GetLength(1); y++)
                {
                    if (pattern.Cells[x, y] == 1)
                        _playground[x + offsetX, y + offsetY].Bear();
                }
            }
        }

        /// <summary>
        /// Lets every cell on the playground age
        /// </summary>
        public int NextGeneration()
        {
            IList<Point> willDie = new List<Point>();
            IList<Point> willBear = new List<Point>();

            for (int x = 0; x < CellsX; x++)
            {
                for (int y = 0; y < CellsY; y++)
                {
                    bool xIncreaseable = false;
                    bool xDecreaseable = false;
                    bool yIncreaseable = false;
                    bool yDecreaseable = false;
                    int neighbours = 0;

                    _playground[x, y].GetsInspected = true;


                    int len = _playground.GetLength(0) - 1;

                    if (len >= x + 1)
                        xIncreaseable = true;
                    if (0 <= x - 1)
                        xDecreaseable = true;


                    len = _playground.GetLength(1) - 1;

                    if (len >= y + 1)
                        yIncreaseable = true;
                    if (0 <= y - 1)
                        yDecreaseable = true;

                    if (xIncreaseable)
                        if (_playground[x + 1, y].IsAlive)
                            neighbours++;
                    if (xDecreaseable)
                        if (_playground[x - 1, y].IsAlive)
                            neighbours++;
                    if (yIncreaseable)
                        if (_playground[x, y + 1].IsAlive)
                            neighbours++;
                    if (yDecreaseable)
                        if (_playground[x, y - 1].IsAlive)
                            neighbours++;
                    if (xIncreaseable && yIncreaseable)
                        if (_playground[x + 1, y + 1].IsAlive)
                            neighbours++;
                    if (xIncreaseable && yDecreaseable)
                        if (_playground[x + 1, y - 1].IsAlive)
                            neighbours++;
                    if (xDecreaseable && yDecreaseable)
                        if (_playground[x - 1, y - 1].IsAlive)
                            neighbours++;
                    if (xDecreaseable && yIncreaseable)
                        if (_playground[x - 1, y + 1].IsAlive)
                            neighbours++;

                    if (!_playground[x, y].IsAlive && neighbours == 3)
                        willBear.Add(new Point(x, y));

                    if (neighbours < 2 || neighbours > 3)
                        if (_playground[x, y].IsAlive)
                            willDie.Add(new Point(x, y));

                    _playground[x, y].GetsInspected = false;
                }
            }

            foreach (Point current in willDie)
                _playground[current.X, current.Y].Kill();
            foreach (Point current in willBear)
                _playground[current.X, current.Y].Bear();

            return _generation++;
        }

        /// <summary>
        /// Gets an enumeration of every cell on the playground
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="Cell2D"/>s which represents every cell on the playground</returns>
        public IEnumerable<Cell2D> GetItems()
        {
            IList<Cell2D> items = new List<Cell2D>();

            for (int x = 0; x < CellsX; x++)
            {
                for (int y = 0; y < CellsY; y++)
                {
                    items.Add(_playground[x, y]);
                }
            }

            return items;
        }

        public void Resize(int width, int height)
        {
            
        }
    }
}
