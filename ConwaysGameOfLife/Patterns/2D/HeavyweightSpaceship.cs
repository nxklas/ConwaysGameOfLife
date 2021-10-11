namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Heavyweight spaceship pattern, founded by John Conway
    /// </summary>
    public sealed class HeavyweightSpaceship : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="HeavyweightSpaceship"/> class
        /// </summary>
        public HeavyweightSpaceship() : base(new int[5, 7]
        {
            { 0, 0, 0, 1, 1, 0, 0 },
            { 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Heavyweight spaceship pattern
        /// </summary>
        public override string Name => "Heavyweight spaceship";
    }
}
