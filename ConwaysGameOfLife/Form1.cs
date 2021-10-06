using ConwaysGameOfLife.Game;
using System;
using System.Windows.Forms;

namespace ConwaysGameOfLife
{
    public partial class Form1 : Form
    {
        private readonly GameManager _game;

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            _game = new();
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (IDrawable current in _game.GetItems())
                current.Draw(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _game.NextGeneration();
            Refresh();
        }
    }
}
