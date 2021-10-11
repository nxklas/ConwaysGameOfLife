namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pre-pulsar pattern, founded by John Conway
    /// </summary>
    public sealed class PrePulsar : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="PrePulsar"/> class
        /// </summary>
        public PrePulsar() : base(new int[3, 9]
        {
            { 1, 1, 1, 0, 0, 0, 1, 1, 1, },
            { 1, 0, 1, 0, 0, 0, 1, 0, 1, },
            { 1, 1, 1, 0, 0, 0, 1, 1, 1, }
        })
        {
        }

        /// <summary>
        /// The name of the Pre-pulsar pattern
        /// </summary>
        public override string Name => "Pre-pulsar";
    }
}
