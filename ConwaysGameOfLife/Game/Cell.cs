namespace ConwaysGameOfLife.Game
{
    /// <summary>
    /// Represents the base class for cells
    /// </summary>
    internal abstract class Cell : IInspect
    {
        private CellState _state;
        private bool _getsInspected;

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
            _getsInspected= false;
        }

        /// <summary>
        /// Indicates whether current cell gets inspected by <see cref="GameManager.NextGeneration"/>
        /// </summary>
        public bool GetsInspected { get => _getsInspected; set => _getsInspected = value; }
        /// <summary>
        /// Indicates whether current cell is alive
        /// </summary>
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
