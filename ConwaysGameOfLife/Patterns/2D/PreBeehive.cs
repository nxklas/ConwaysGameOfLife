namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pre-beehive pattern, founded by John Conway
    /// </summary>
    public sealed class PreBeehive : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PreBeehive"/> class
        /// </summary>
        public PreBeehive() : base(new int[2, 3]
        {
            { 1, 1, 1 },
            { 1, 1, 1 }
        })
        {
        }

        /// <summary>
        /// The name of the Pre-beehive pattern
        /// </summary>
        public override string Name => "Pre-beehive";
    }
}
