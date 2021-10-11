namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Blinker pattern, founded by John Conway
    /// </summary>
    public sealed class Blinker : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Blinker"/> class
        /// </summary>
        public Blinker() : base(new int[3, 1]
        {
            { 1 },
            { 1 },
            { 1 }
        })
        {
        }

        /// <summary>
        /// The name of the Blinker pattern
        /// </summary>
        public override string Name => "Blinker";
    }
}
