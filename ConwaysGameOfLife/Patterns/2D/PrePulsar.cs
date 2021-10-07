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
        public PrePulsar() : base()
        {
        }

        /// <summary>
        /// The name of the Pre-pulsar pattern
        /// </summary>
        public override string Name => "Pre-pulsar";
        /// <summary>
        /// The cells inside the Pre-pulsar pattern
        /// </summary>
        public override int[,] Cells => new int[3, 9]
        {
            { 1, 1, 1, 0, 0, 0, 1, 1, 1, },
            { 1, 0, 1, 0, 0, 0, 1, 0, 1, },
            { 1, 1, 1, 0, 0, 0, 1, 1, 1, }
        };
    }
}
