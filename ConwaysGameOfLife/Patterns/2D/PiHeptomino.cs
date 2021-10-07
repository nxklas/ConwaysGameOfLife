namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pi-heptomino pattern, founded by John Conway
    /// </summary>
    public sealed class PiHeptomino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PiHeptomino"/> class
        /// </summary>
        public PiHeptomino() : base()
        {
        }

        /// <summary>
        /// The name of the Pi-heptomino pattern
        /// </summary>
        public override string Name => "Pi-heptomino";
        /// <summary>
        /// The cells inside the Pi-heptomino pattern
        /// </summary>
        public override int[,] Cells => new int[3, 3]
        {
            { 1, 1, 1},
            { 1, 0, 1},
            { 1, 0, 1}
        };
    }
}
