using ConwaysGameOfLife.Translators;

namespace ConwaysGameOfLife.Abstracts
{
    /// <summary>
    /// Represents the base class for cells
    /// </summary>
    public abstract class Cell
    {
        protected CellState _state;

        /// <summary>
        /// Initializes a new instance of <see cref="Cell"/> class which is dead
        /// </summary>
        public Cell() : this(CellState.Dead)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Cell"/> class and sets it's state (alive / dead)
        /// </summary>
        /// <param name="state">Indicates the state of the cell (alive / dead)</param>
        public Cell(CellState state)
        {
            _state = state;
        }

        /// <summary>
        /// Indicates whether current cell gets inspected by <see cref="GameManager2D.NextGeneration"/>
        /// </summary>
        /// <summary>
        /// Indicates whether current cell is alive
        /// </summary>
        /// <returns><see langword="true"/> if current cell is alive; otherwise, <see langword="false"/></returns>
        public bool IsAlive => _state == CellState.Alive;
        /// <summary>
        /// Kills the current cell
        /// </summary>
        public void Kill() => _state = CellState.Dead;
        /// <summary>
        /// Gives birth to the current cell
        /// </summary>
        public void Bear() => _state = CellState.Alive;
    }
}
