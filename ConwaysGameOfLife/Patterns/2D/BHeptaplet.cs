﻿namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the B-heptaplet pattern, founded by John Conway
    /// </summary>
    public sealed class BHeptaplet : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BHeptaplet"/> class
        /// </summary>
        public BHeptaplet() : base()
        {
        }

        /// <summary>
        /// The name of the B-heptaplet pattern
        /// </summary>
        public override string Name => "B-heptaplet";
        /// <summary>
        /// The cells inside the B-heptaplet pattern
        /// </summary>
        public override int[,] Cells => new int[3, 5]
        {
            { 1, 0, 0, 1, 1 },
            { 0, 1, 1, 1, 0 },
            { 0, 0, 1, 0, 0 },
        };
    }
}
