namespace ConwaysGameOfLife.Patterns
{
    /// <summary>
    /// Represents the base classe for 2-dimensional patterns
    /// </summary>
    public abstract class Pattern2D : IPattern
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Pattern2D"/> class
        /// </summary>
        protected Pattern2D()
        {
        }

        /// <summary>
        /// The name of the specific 2-dimensional pattern
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// The cells inside the specific 2-dimensional pattern
        /// </summary>
        public abstract int[,] Cells { get; }
    }
}
