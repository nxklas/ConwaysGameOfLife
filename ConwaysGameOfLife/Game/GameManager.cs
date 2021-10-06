using System.Collections.Generic;
using System.Drawing;

namespace ConwaysGameOfLife.Game
{
    /// <summary>
    /// Represents the manager for Conway's Game of Life
    /// </summary>
    internal sealed class GameManager
    {
        private const int CellsX = 39;
        private const int CellsY = 22;
        private Cell2D[,] _playground;

        /// <summary>
        /// Initializes a new instance of <see cref="GameManager"/> class
        /// </summary>
        public GameManager()
        {
            _playground = new Cell2D[CellsX, CellsY];
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

            InitFigure();
        }

        //TODO: add classes for various figures; add bounds and handle them (if figure goes out of them)

        /// <summary>
        /// Initializes the init pattern
        /// </summary>
        private void InitFigure()
        {
            int middle = 15;

            _playground[middle, middle - 1].Bear();
            _playground[middle, middle].Bear();
            _playground[middle, middle + 1].Bear();

            middle = 1;

            _playground[middle - 1, middle].Bear();
            _playground[middle, middle].Bear();
            _playground[middle + 1, middle].Bear();

            middle = 8;

            _playground[middle - 1, middle].Bear();
            _playground[middle, middle].Bear();
            _playground[middle + 1, middle].Bear();
            _playground[middle + 1, middle-1].Bear();
            _playground[middle, middle - 2].Bear();
        }

        /// <summary>
        /// Lets every cell on the playground age
        /// </summary>
        public void NextGeneration()
        {
            IList<Point> willDie = new List<Point>();
            IList<Point> willBorn = new List<Point>();

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
                        willBorn.Add(new Point(x, y));

                    if (neighbours < 2 || neighbours > 3)
                        if (_playground[x, y].IsAlive)
                            willDie.Add(new Point(x, y));

                    _playground[x, y].GetsInspected = false;
                }
            }

            foreach (var current in willDie)
                _playground[current.X, current.Y].Kill();
            foreach (var current in willBorn)
                _playground[current.X, current.Y].Bear();
        }

        /// <summary>
        /// Gets an enumeration of every cell on the playground
        /// </summary>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="IDrawable"/>s which represents every cell on the playground</returns>
        public IEnumerable<IDrawable> GetItems()
        {
            IList<IDrawable> items = new List<IDrawable>();

            for (int x = 0; x < CellsX; x++)
            {
                for (int y = 0; y < CellsY; y++)
                {
                    items.Add(_playground[x, y]);
                }
            }

            return items;
        }
    }
}
