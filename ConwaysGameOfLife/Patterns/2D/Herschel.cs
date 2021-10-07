namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Herschel pattern, founded by John Conway
    /// </summary>
    public sealed class Herschel : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Herschel"/> class
        /// </summary>
        public Herschel() : base()
        {
        }

        /// <summary>
        /// The name of the Herschel pattern
        /// </summary>
        public override string Name => "Herschel";
        /// <summary>
        /// The cells inside the Herschel pattern
        /// </summary>
        public override int[,] Cells => new int[4, 3]
        {
            { 1, 0, 0 },
            { 1, 1, 1 },
            { 1, 0, 1 },
            { 0, 0, 1 },
        };
    }
}
