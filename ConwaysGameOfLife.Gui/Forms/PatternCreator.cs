using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConwaysGameOfLife.Gui.Forms
{
    public partial class PatternCreator : Form
    {
        private int _width;
        private int _height;

        public PatternCreator()
        {
            InitializeComponent();
        }

        private void PatternCreator_Load(object sender, EventArgs e)
        {
            PatternSizeSetter sizeSetter = new PatternSizeSetter();
            sizeSetter.Closed += (width, height) => PatternSizeSetter_Closed(width, height);
            sizeSetter.ShowDialog();
        }

        private void PatternSizeSetter_Closed(int width, int height)
        {
            _width = width;
            _height = height;
        }
    }
}
