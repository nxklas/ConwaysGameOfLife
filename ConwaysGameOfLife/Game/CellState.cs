namespace ConwaysGameOfLife.Game
{
    /// <summary>
    /// Represents a set of states <see cref="Cell"/> instances can attain
    /// </summary>
    internal enum CellState
    {
        /// <summary>
        /// Indicates that a <see cref="Cell"/> instance is alive
        /// </summary>
        Alive,
        /// <summary>
        /// Indicates that a <see cref="Cell"/> instance is dead
        /// </summary>
        Dead
    }
}
