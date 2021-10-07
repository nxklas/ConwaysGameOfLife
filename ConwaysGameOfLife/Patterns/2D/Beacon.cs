namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Beacon pattern, founded by John Conway
    /// </summary>
    public sealed class Beacon : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Beacon"/> class
        /// </summary>
        public Beacon() : base()
        {
        }

        /// <summary>
        /// The name of the Beacon pattern
        /// </summary>
        public override string Name => "Beacon";

        /// <summary>
        /// The cells inside the Beacon pattern
        /// </summary>
        public override int[,] Cells => new int[4, 4]
        {
            { 1, 1, 0, 0 },
            { 1, 1, 0, 0 },
            { 0, 0, 1, 1 },
            { 0, 0, 1, 1 }
        };
    }
}
