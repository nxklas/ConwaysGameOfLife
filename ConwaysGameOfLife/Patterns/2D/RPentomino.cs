namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the R-pentomino pattern, founded by John Conway
    /// </summary>
    public sealed class RPentomino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="RPentomino"/> class
        /// </summary>
        public RPentomino() : base()
        {
        }

        /// <summary>
        /// The name of the R-pentomino pattern
        /// </summary>
        public override string Name => "R-pentomino";
        /// <summary>
        /// The cells inside the R-pentomino pattern
        /// </summary>
        public override int[,] Cells => new int[3, 3]
        {
            { 0, 1, 1 },
            { 1, 1, 0 },
            { 0, 1, 0 }
        };
    }
}
