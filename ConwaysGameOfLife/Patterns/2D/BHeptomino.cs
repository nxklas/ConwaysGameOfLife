namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the B-heptomino pattern, founded by John Conway
    /// </summary>
    public sealed class BHeptomino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="BHeptomino"/> class
        /// </summary>
        public BHeptomino() : base()
        {
        }

        /// <summary>
        /// The name of the B-heptomino pattern
        /// </summary>
        public override string Name => "B-heptomino";
        /// <summary>
        /// The cells inside the B-heptomino pattern
        /// </summary>
        public override int[,] Cells => new int[3, 4]
        {
            { 1, 0, 1, 1 },
            { 1, 1, 1, 0 },
            { 0, 1, 0, 0 },
        };
    }
}
