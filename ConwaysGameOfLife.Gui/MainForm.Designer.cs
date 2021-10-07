
namespace ConwaysGameOfLife.Gui
{
    internal sealed partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._idleLoop = new System.Windows.Forms.Timer(this.components);
            this._lGeneration = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _idleLoop
            // 
            this._idleLoop.Interval = 1000;
            this._idleLoop.Tick += new System.EventHandler(this._idleLoop_Tick);
            // 
            // _lGeneration
            // 
            this._lGeneration.AutoSize = true;
            this._lGeneration.Dock = System.Windows.Forms.DockStyle.Right;
            this._lGeneration.Location = new System.Drawing.Point(732, 0);
            this._lGeneration.Name = "_lGeneration";
            this._lGeneration.Size = new System.Drawing.Size(68, 15);
            this._lGeneration.TabIndex = 0;
            this._lGeneration.Text = "Generation:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._lGeneration);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _idleLoop;
        private System.Windows.Forms.Label _lGeneration;
    }
}

