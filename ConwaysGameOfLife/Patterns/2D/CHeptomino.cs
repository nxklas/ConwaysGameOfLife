namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the C-heptomino pattern, founded by John Conway
    /// </summary>
    public sealed class CHeptomino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CHeptomino"/> class
        /// </summary>
        public CHeptomino() : base()
        {
        }

        /// <summary>
        /// The name of the C-heptomino pattern
        /// </summary>
        public override string Name => "C-heptomino";
        /// <summary>
        /// The cells inside the C-heptomino pattern
        /// </summary>
        public override int[,] Cells => new int[3, 4]
        {
            { 0, 1, 1,1 },
            { 1, 1,1,0 },
            { 0, 1,0,0 }
        };
    }
}
