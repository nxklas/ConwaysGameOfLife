namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the E-heptomino pattern, founded by John Conway
    /// </summary>
    public sealed class EHeptomino : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="EHeptomino"/> class
        /// </summary>
        public EHeptomino() : base(new int[3, 4]
        {
            { 0, 1, 1, 1 },
            { 1, 1, 0, 0 },
            { 0, 1, 1, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the E-heptomino pattern
        /// </summary>
        public override string Name => "E-heptomino";
    }
}
