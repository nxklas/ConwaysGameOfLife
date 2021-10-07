namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Block pattern, founded by John Conway
    /// </summary>
    public sealed class Block : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Block"/> class
        /// </summary>
        public Block() : base()
        {
        }

        /// <summary>
        /// The name of the Block pattern
        /// </summary>
        public override string Name => "Block";
        /// <summary>
        /// The cells inside the Block pattern
        /// </summary>
        public override int[,] Cells => new int[2, 2]
        {
            { 1, 1 },
            { 1, 1 }
        };
    }
}
