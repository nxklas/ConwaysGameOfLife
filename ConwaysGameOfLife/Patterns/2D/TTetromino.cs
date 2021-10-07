﻿namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the T-tetromino pattern, founded by John Conway
    /// </summary>
    public sealed class TTetromino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TTetromino"/> class
        /// </summary>
        public TTetromino() : base()
        {
        }

        /// <summary>
        /// The name of the T-tetromino pattern
        /// </summary>
        public override string Name => "T-tetromino";
        /// <summary>
        /// The cells inside the T-tetromino pattern
        /// </summary>
        public override int[,] Cells => new int[2, 3]
        {
            { 1, 1, 1 },
            { 0, 1, 0 }
        };
    }
}
