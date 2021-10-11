namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Lightweight spaceship pattern, founded by John Conway
    /// </summary>
    public sealed class LightweightSpaceship : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="LightweightSpaceship"/> class
        /// </summary>
        public LightweightSpaceship() : base(new int[4, 5]
        {
            { 0, 1, 0, 0, 1 },
            { 1, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Lightweight spaceship pattern
        /// </summary>
        public override string Name => "Lightweight spaceship";
    }
}
