namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pre-block pattern, founded by John Conway
    /// </summary>
    public sealed class PreBlock : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PreBlock"/> class
        /// </summary>
        public PreBlock() : base()
        {
        }

        /// <summary>
        /// The name of the Pre-block pattern
        /// </summary>
        public override string Name => "Pre-block";
        /// <summary>
        /// The cells inside the Pre-block pattern
        /// </summary>
        public override int[,] Cells => new int[2, 2]
        {
            { 1, 0 },
            { 1, 1 },
        };
    }
}
