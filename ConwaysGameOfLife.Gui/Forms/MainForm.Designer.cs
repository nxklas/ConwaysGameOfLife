
namespace ConwaysGameOfLife.Gui.Forms
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
            this._painter = new ConwaysGameOfLife.Gui.Controls.Painter();
            this._btnStartPause = new System.Windows.Forms.Button();
            this._btnStop = new System.Windows.Forms.Button();
            this._lBPatterns = new System.Windows.Forms.ListBox();
            this._btnCreatePattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _idleLoop
            // 
            this._idleLoop.Interval = 20;
            this._idleLoop.Tick += new System.EventHandler(this._idleLoop_Tick);
            // 
            // _painter
            // 
            this._painter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._painter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this._painter.DoubleBuffered = true;
            this._painter.Location = new System.Drawing.Point(12, 12);
            this._painter.Name = "_painter";
            this._painter.Size = new System.Drawing.Size(683, 434);
            this._painter.TabIndex = 1;
            this._painter.Click += new System.EventHandler(this._painter_Click);
            this._painter.Paint += new System.Windows.Forms.PaintEventHandler(this._painter_Paint);
            this._painter.MouseMove += new System.Windows.Forms.MouseEventHandler(this._painter_MouseMove);
            this._painter.Resize += new System.EventHandler(this._painter_Resize);
            // 
            // _btnStartPause
            // 
            this._btnStartPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStartPause.BackgroundImage = global::ConwaysGameOfLife.Gui.Properties.Resources.playIcon;
            this._btnStartPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnStartPause.Location = new System.Drawing.Point(701, 12);
            this._btnStartPause.Name = "_btnStartPause";
            this._btnStartPause.Size = new System.Drawing.Size(55, 55);
            this._btnStartPause.TabIndex = 2;
            this._btnStartPause.UseVisualStyleBackColor = true;
            this._btnStartPause.Click += new System.EventHandler(this._btnStartStop_Click);
            // 
            // _btnStop
            // 
            this._btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStop.BackgroundImage = global::ConwaysGameOfLife.Gui.Properties.Resources.playIcon;
            this._btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._btnStop.Location = new System.Drawing.Point(762, 12);
            this._btnStop.Name = "_btnStop";
            this._btnStop.Size = new System.Drawing.Size(55, 55);
            this._btnStop.TabIndex = 3;
            this._btnStop.UseVisualStyleBackColor = true;
            this._btnStop.Visible = false;
            // 
            // _lBPatterns
            // 
            this._lBPatterns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lBPatterns.FormattingEnabled = true;
            this._lBPatterns.ItemHeight = 15;
            this._lBPatterns.Location = new System.Drawing.Point(701, 118);
            this._lBPatterns.Name = "_lBPatterns";
            this._lBPatterns.Size = new System.Drawing.Size(116, 334);
            this._lBPatterns.TabIndex = 4;
            this._lBPatterns.SelectedIndexChanged += new System.EventHandler(this._lBPatterns_SelectedIndexChanged);
            // 
            // _btnCreatePattern
            // 
            this._btnCreatePattern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCreatePattern.Location = new System.Drawing.Point(701, 89);
            this._btnCreatePattern.Name = "_btnCreatePattern";
            this._btnCreatePattern.Size = new System.Drawing.Size(114, 23);
            this._btnCreatePattern.TabIndex = 5;
            this._btnCreatePattern.Text = "Create Pattern";
            this._btnCreatePattern.UseVisualStyleBackColor = true;
            this._btnCreatePattern.Click += new System.EventHandler(this._btnCreatePattern_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 458);
            this.Controls.Add(this._btnCreatePattern);
            this.Controls.Add(this._lBPatterns);
            this.Controls.Add(this._btnStop);
            this.Controls.Add(this._btnStartPause);
            this.Controls.Add(this._painter);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer _idleLoop;
        private Controls.Painter _painter;
        private System.Windows.Forms.Button _btnStartPause;
        private System.Windows.Forms.Button _btnStop;
        private System.Windows.Forms.ListBox _lBPatterns;
        private System.Windows.Forms.Button _btnCreatePattern;
    }
}

