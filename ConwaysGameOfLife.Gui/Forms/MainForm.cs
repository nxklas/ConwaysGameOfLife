using static ConwaysGameOfLife.Gui.Properties.Resources;
using ConwaysGameOfLife.Patterns;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConwaysGameOfLife.Gui.Forms
{
    /// <summary>
    /// Represents the main formular where the game takes place
    /// </summary>
    internal sealed partial class MainForm : Form
    {
        private readonly GameManager2D _game;
        private Pattern2D _previewPattern;
        private Point _previewPatternOffset;

        /// <summary>
        /// Initializes a new instance of <see cref="MainForm"/> class
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _game = new(_painter.Width, _painter.Height);
            _previewPatternOffset = new Point();
            foreach (string current in _game.GetNativePatternNames())
                _lBPatterns.Items.Add(current);
            _painter.MouseWheel += (sender, e) => MouseScroll(e);
        }

        private void MouseScroll(MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                _game.ScaleUp();
            }
            else //if(e.Delta < 0)
            {
                _game.ScaleDown();
            }
            _painter.Refresh();
        }

        private void _idleLoop_Tick(object sender, EventArgs e)
        {
            _game.NextGeneration();
            _painter.Refresh();
        }

        private void _btnStartStop_Click(object sender, EventArgs e)
        {
            switch (_idleLoop.Enabled)
            {
                case true:
                    _idleLoop.Stop();
                    _btnStop.Visible = false;
                    _btnStartPause.BackgroundImage = playIcon;
                    break;
                default:
                    _idleLoop.Start();
                    _btnStop.Visible = true;
                    _btnStartPause.BackgroundImage = pauseIcon;
                    break;
            }
        }

        private void _painter_Paint(object sender, PaintEventArgs e)
        {
            foreach (Cell2D current in _game.GetItems())
                current.Draw(e.Graphics);

            if (_previewPattern != null)
                foreach (Abstracts.Cell current in _previewPattern.Manufacture(_previewPatternOffset.X, _previewPatternOffset.Y))
                    (current as Cell2D).Draw(e.Graphics);
        }

        private void _painter_Resize(object sender, EventArgs e)
        {
            _game.Resize(_painter.Width, _painter.Height);
            _painter.Refresh();
        }

        private void _painter_MouseMove(object sender, MouseEventArgs e)
        {
            if (_idleLoop.Enabled)
                return;
            _previewPatternOffset = new Point(e.X, e.Y);
            _painter.Refresh();
        }

        private void _lBPatterns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lBPatterns.SelectedIndex > -1)
                _previewPattern = _game.GetPattern(_lBPatterns.Items[_lBPatterns.SelectedIndex].ToString());
        }

        private void _painter_Click(object sender, EventArgs e)
        {
            if (_previewPattern != null)
            {
                _game.SetPattern(_previewPattern);
                _previewPattern = null;
                _lBPatterns.SelectedIndex = -1;
            }
        }

        private void _btnCreatePattern_Click(object sender, EventArgs e)
        {
            new PatternCreator().Show();
        }
    }
}
