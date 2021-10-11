namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pentadecathlon pattern, founded by John Conway
    /// </summary>
    public sealed class Pentadecathlon : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Pentadecathlon"/> class
        /// </summary>
        public Pentadecathlon() : base(new int[3, 10]
        {
            { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 },
            { 1, 1, 0, 1, 1, 1, 1, 0, 1, 1 },
            { 0, 0, 1, 0, 0, 0, 0, 1, 0, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Pentadecathlon pattern
        /// </summary>
        public override string Name => "Pentadecathlon";
    }
}
