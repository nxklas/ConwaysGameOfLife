
namespace ConwaysGameOfLife.Gui.Forms
{
    partial class PatternSizeSetter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lWidth = new System.Windows.Forms.Label();
            this._tBWidth = new System.Windows.Forms.TextBox();
            this._tBHeight = new System.Windows.Forms.TextBox();
            this._lHeight = new System.Windows.Forms.Label();
            this._btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lWidth
            // 
            this._lWidth.AutoSize = true;
            this._lWidth.Location = new System.Drawing.Point(12, 13);
            this._lWidth.Name = "_lWidth";
            this._lWidth.Size = new System.Drawing.Size(78, 15);
            this._lWidth.TabIndex = 0;
            this._lWidth.Text = "Pattern width";
            // 
            // _tBWidth
            // 
            this._tBWidth.Location = new System.Drawing.Point(12, 31);
            this._tBWidth.Name = "_tBWidth";
            this._tBWidth.Size = new System.Drawing.Size(100, 23);
            this._tBWidth.TabIndex = 1;
            this._tBWidth.TextChanged += new System.EventHandler(this._tBWidth_TextChanged);
            // 
            // _tBHeight
            // 
            this._tBHeight.Location = new System.Drawing.Point(118, 31);
            this._tBHeight.Name = "_tBHeight";
            this._tBHeight.Size = new System.Drawing.Size(100, 23);
            this._tBHeight.TabIndex = 3;
            this._tBHeight.TextChanged += new System.EventHandler(this._tBHeight_TextChanged);
            // 
            // _lHeight
            // 
            this._lHeight.AutoSize = true;
            this._lHeight.Location = new System.Drawing.Point(118, 13);
            this._lHeight.Name = "_lHeight";
            this._lHeight.Size = new System.Drawing.Size(82, 15);
            this._lHeight.TabIndex = 2;
            this._lHeight.Text = "Pattern height";
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(12, 60);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(206, 23);
            this._btnClose.TabIndex = 4;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // PatternSizeSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 228);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._tBHeight);
            this.Controls.Add(this._lHeight);
            this.Controls.Add(this._tBWidth);
            this.Controls.Add(this._lWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PatternSizeSetter";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "PatternSizeSetter";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lWidth;
        private System.Windows.Forms.TextBox _tBWidth;
        private System.Windows.Forms.TextBox _tBHeight;
        private System.Windows.Forms.Label _lHeight;
        private System.Windows.Forms.Button _btnClose;
    }
}