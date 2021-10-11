namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Overweight spaceship pattern, founded by John Conway
    /// </summary>
    public sealed class OverweightSpaceship : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="OverweightSpaceship"/> class
        /// </summary>
        public OverweightSpaceship() : base(new int[5, 8]
        {
            { 0, 0, 0, 1, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Overweight spaceship pattern
        /// </summary>
        public override string Name => "Overweight spaceship";
    }
}
