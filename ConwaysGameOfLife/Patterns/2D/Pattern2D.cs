using ConwaysGameOfLife.Abstracts;
using ConwaysGameOfLife.Translators;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the base classe for 2-dimensional patterns
    /// </summary>
    public abstract class Pattern2D : IPattern
    {
        private int[,] _cells;
        private double _offsetY;
        private double _offsetX;

        /// <summary>
        /// Initializes a new instance of <see cref="Pattern2D"/> class
        /// </summary>
        protected Pattern2D(int[,] cells)
        {
            Set(cells);
        }

        public int OffsetX => (int)_offsetX;
        public int OffsetY => (int)_offsetY;

        /// <summary>
        /// The name of the specific 2-dimensional pattern
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// The cells inside the specific 2-dimensional pattern
        /// </summary>
        public int[,] Cells => _cells;

        /// <summary>
        /// Mirrors the current pattern
        /// </summary>
        protected void Mirror(MirrorOptions option = MirrorOptions.Horizontally)
        {
            int lenX = _cells.GetLength(0);
            int lenY = _cells.GetLength(1);
            int[,] mirrored = new int[lenX, lenY];

            switch (option)
            {
                case MirrorOptions.Horizontally:
                    for (int x = lenX - 1; x > -1; x--)
                    {
                        for (int y = lenY - 1; y > -1; y--)
                        {
                            mirrored[lenX - x - 1, y] = _cells[x, y];
                        }
                    }
                    break;
                case MirrorOptions.Vertically:
                    for (int x = lenX - 1; x > -1; x--)
                    {
                        for (int y = lenY - 1; y > -1; y--)
                        {
                            mirrored[x, lenY - y - 1] = _cells[x, y];
                        }
                    }
                    break;
            }

            _cells = mirrored;
        }

        /// <summary>
        /// Tilts the current pattern
        /// </summary>
        protected void Tilt(TiltOptions option)
        {
            for (int i = 0; i < (int)option; i++)
                Tilt();
        }

        private void Tilt()
        {
            int lenX = _cells.GetLength(0);
            int lenY = _cells.GetLength(1);
            int[,] tilted = new int[lenY, lenX];

            for (int x = lenX - 1; x > -1; x--)
            {
                for (int y = lenY - 1; y > -1; y--)
                {
                    tilted[lenY - y - 1, x] = _cells[x, y];
                }
            }

            _cells = tilted;
        }

        /// <summary>
        /// Sets the current pattern
        /// </summary>
        /// <param name="cells"></param>
        protected void Set(int[,] cells)
        {
            _cells = cells;
        }

        public IEnumerable<Cell> Manufacture(int offsetX, int offsetY)
        {
            _offsetX = offsetX - (_cells.GetLength(1) / 2) * Cell2D.Width;
            _offsetY = offsetY - (_cells.GetLength(0) / 2) * Cell2D.Heigth;
            IList<Cell> cells = new List<Cell>();
            for (int x = 0; x < Cells.GetLength(1); x++)
                for (int y = 0; y < Cells.GetLength(0); y++)
                    if (Cells[y, x] == 1)
                    {
                        double relX = x * Cell2D.Width + _offsetX;
                        double relY = y * Cell2D.Heigth + _offsetY;

                        cells.Add(new Cell2D(new Point((int)relX, (int)relY), CellState.Preview));
                    }
            return cells;
        }

        public IEnumerable<Cell> Manufacture()
        {
            IList<Cell> cells = new List<Cell>();

            for (int x = 0; x < Cells.GetLength(1); x++)
                for (int y = 0; y < Cells.GetLength(0); y++)
                    if (Cells[y, x] == 1)
                        cells.Add(new Cell2D(new Point(x, y), CellState.Preview));

            return cells;
        }

        /// <summary>
        /// Represents a set of options which indicate the degree of tilt
        /// </summary>
        public enum TiltOptions
        {
            /// <summary>
            /// Indicates that a pattern gets tilted by 90 degrees
            /// </summary>
            OneQuarter = 1,
            /// <summary>
            /// Indicates that a pattern gets tilted by 180 degrees
            /// </summary>
            TwoQuarters = 2,
            /// <summary>
            /// Indicates that a pattern gets tilted by 270 degrees
            /// </summary>
            ThreeQuarters = 3
        }

        /// <summary>
        /// Represents a set of options which indicate of to mirror
        /// </summary>
        public enum MirrorOptions
        {
            /// <summary>
            /// Indicates that a pattern gets mirrored horizontally
            /// </summary>
            Horizontally,
            /// <summary>
            /// Indicates that a pattern gets mirrored vertically
            /// </summary>
            Vertically
        }
    }
}