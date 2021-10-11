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

        /// <summary>
        /// Initializes a new instance of <see cref="Pattern2D"/> class
        /// </summary>
        protected Pattern2D(int[,] cells) => Set(cells);

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
        protected void Mirror(MirrorOptions options = MirrorOptions.Horizontally)
        {
            int lenX = _cells.GetLength(0);
            int lenY = _cells.GetLength(1);
            Dictionary<Point, int> tempStorage = new();
            int[,] mirrored = new int[lenX, lenY];

            switch (options)
            {
                case MirrorOptions.Horizontally:
                    for (int x = lenX - 1; x > -1; x--)
                    {
                        for (int y = lenY - 1; y > -1; y--)
                        {
                            tempStorage.Add(new Point(lenX - x - 1, y), _cells[x, y]);
                        }
                    }
                    break;
                case MirrorOptions.Vertically:
                    for (int x = lenX - 1; x > -1; x--)
                    {
                        for (int y = lenY - 1; y > -1; y--)
                        {
                            tempStorage.Add(new Point(x, lenY - y - 1), _cells[x, y]);
                        }
                    }
                    break;
            }

            foreach (KeyValuePair<Point, int> current in tempStorage)
            {
                mirrored[current.Key.X, current.Key.Y] = current.Value;
            }

            _cells = mirrored;
        }

        /// <summary>
        /// Tilts the current pattern
        /// </summary>
        protected void Tilt(TiltOptions options)
        {
            for (int i = 0; i < (int)options; i++)
                Tilt();
        }

        private void Tilt()
        {
            int lenX = _cells.GetLength(0);
            int lenY = _cells.GetLength(1);
            Dictionary<Point, int> tempStorage = new();
            int[,] tilted = new int[lenY, lenX];

            for (int x = lenX - 1; x > -1; x--)
            {
                for (int y = lenY - 1; y > -1; y--)
                {
                    tempStorage.Add(new Point(x, lenY - y - 1), _cells[x, y]);
                }
            }

            foreach (KeyValuePair<Point, int> current in tempStorage)
            {
                tilted[current.Key.Y, current.Key.X] = current.Value;
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
            Mirror();
            Tilt(TiltOptions.ThreeQuarters);
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