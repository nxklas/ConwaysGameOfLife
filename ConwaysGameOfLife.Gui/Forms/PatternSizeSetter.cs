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
    public partial class PatternSizeSetter : Form
    {
        private ushort _width;
        private ushort _height;

        public PatternSizeSetter()
        {
            InitializeComponent();
        }

        private void _tBWidth_TextChanged(object sender, EventArgs e)
        {
            if (ushort.TryParse(_tBWidth.Text, out ushort width))
            {
                _tBWidth.BackColor = Color.FromKnownColor(KnownColor.Green);
                _width = width;
                if (_tBWidth.BackColor == Color.FromKnownColor(KnownColor.Green) && _tBHeight.BackColor == Color.FromKnownColor(KnownColor.Green))
                    _btnClose.Enabled = true;
                return;
            }
            _btnClose.Enabled = false;
            _tBWidth.BackColor = Color.FromKnownColor(KnownColor.Red);
        }

        private void _tBHeight_TextChanged(object sender, EventArgs e)
        {
            if (ushort.TryParse(_tBHeight.Text, out ushort height))
            {
                _tBHeight.BackColor = Color.FromKnownColor(KnownColor.Green);
                _height = height;
                if (_tBWidth.BackColor == Color.FromKnownColor(KnownColor.Green) && _tBHeight.BackColor == Color.FromKnownColor(KnownColor.Green))
                    _btnClose.Enabled = true;
                return;
            }
            _btnClose.Enabled = false;
            _tBHeight.BackColor = Color.FromKnownColor(KnownColor.Red);
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Closed?.Invoke(_width,_height);
            Close();
        }

        public delegate void SizePasser(int width, int height);
        public new event SizePasser Closed;
    }
}
