using System;
using System.Collections.Generic;

namespace ConwaysGameOfLife.Abstracts
{
    internal sealed class Universe2D : Universe
    {
        private readonly bool[,] _universe;

        public Universe2D(int cellsX, int cellsY) : base()
        {
            _universe = new bool[cellsX, cellsY];
        }

        public override int GetLength(int dimension)
        {
            if (dimension > 1)
                throw new ArgumentException($"GetLength: The parameter '{nameof(dimension)}' must have a value between 0 and 1. Actual value: {dimension}", nameof(dimension));

            return _universe.GetLength(dimension);
        }

        public bool this[int indexX, int indexY]
        {
            get
            {
                bool indexXValid = false;
                bool indexYValid = false;

                if (indexX > -1 && indexX < _universe.GetLength(0))
                    indexXValid = true;
                if (indexY > -1 && indexY < _universe.GetLength(1))
                    indexYValid = true;
                if (!indexXValid && !indexYValid)
                    throw new ArgumentException($"this: The parameter '{nameof(indexX)}' must have a value between 0 and {_universe.GetLength(0)} and the parameter '{nameof(indexY)}' must have a value between 0 and {_universe.GetLength(1)}.{Environment.NewLine}" +
                        $"Value of {nameof(indexX)}: {indexX}{Environment.NewLine}" +
                        $"Value of {nameof(indexY)}: {indexY}", $"{nameof(indexX)}, {nameof(indexY)}");
                if (!indexXValid)
                    throw new ArgumentException($"this: The parameter '{nameof(indexX)}' must have a value between 0 and {_universe.GetLength(0)}. Actual value: {indexX}", nameof(indexX));
                if (!indexYValid)
                    throw new ArgumentException($"this: The parameter '{nameof(indexY)}' must have a value between 0 and {_universe.GetLength(1)}. Actual value: {indexY}", nameof(indexY));
                return _universe[indexX, indexY];
            }
            set
            {
                bool indexXValid = false;
                bool indexYValid = false;

                if (indexX > -1 && indexX < _universe.GetLength(0))
                    indexXValid = true;
                if (indexY > -1 && indexY < _universe.GetLength(1))
                    indexYValid = true;
                if (!indexXValid && !indexYValid)
                    throw new ArgumentException($"The parameter '{nameof(indexX)}' must have a value between 0 and {_universe.GetLength(0)} and the parameter '{nameof(indexY)}' must have a value between 0 and {_universe.GetLength(1)}.{Environment.NewLine}" +
                        $"Value of {nameof(indexX)}: {indexX}{Environment.NewLine}" +
                        $"Value of {nameof(indexY)}: {indexY}", $"{nameof(indexX)}, {nameof(indexY)}");
                if (!indexXValid)
                    throw new ArgumentException($"The parameter '{nameof(indexX)}' must have a value between 0 and {_universe.GetLength(0)}. Actual value: {indexX}", nameof(indexX));
                if (!indexYValid)
                    throw new ArgumentException($"The parameter '{nameof(indexY)}' must have a value between 0 and {_universe.GetLength(1)}. Actual value: {indexY}", nameof(indexY));
                _universe[indexX, indexY] = value;
            }
        }

        public override IEnumerator<Cell> GetEnumerator()
        {
            return _universe.GetEnumerator() as IEnumerator<Cell>;
        }
    }
}
