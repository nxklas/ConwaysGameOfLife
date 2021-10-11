namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Middleweight spaceship pattern, founded by John Conway
    /// </summary>
    public sealed class MiddleweightSpaceship : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="MiddleweightSpaceship"/> class
        /// </summary>
        public MiddleweightSpaceship() : base(new int[5, 6]
        {
            { 0, 0, 0, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Middleweight spaceship pattern
        /// </summary>
        public override string Name => "Middleweight spaceship";
    }
}
