using System;
using System.Windows.Forms;

namespace ConwaysGameOfLife.Gui
{
    /// <summary>
    /// Represents the main formular where the game takes place
    /// </summary>
    internal sealed partial class MainForm : Form
    {
        private readonly GameManager2D _game;

        /// <summary>
        /// Initializes a new instance of <see cref="MainForm"/> class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _game = new();
            _idleLoop.Start();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Cell2D current in _game.GetItems())
                current.Draw(e.Graphics);
        }

        private void _idleLoop_Tick(object sender, EventArgs e)
        {
            _lGeneration.Text = "Generation: " + _game.NextGeneration();
            Refresh();
        }
    }
}
