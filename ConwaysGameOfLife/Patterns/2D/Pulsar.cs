namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the Pulsar pattern, founded by John Conway
    /// </summary>
    public sealed class Pulsar : Pattern2D
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Pulsar"/> class
        /// </summary>
        public Pulsar() : base(new int[13, 13]
        {
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 1 },
            { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0 }
        })
        {
        }

        /// <summary>
        /// The name of the Pulsar pattern
        /// </summary>
        public override string Name => "Pulsar";
    }
}
