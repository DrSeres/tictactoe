
namespace tiktak
{
    partial class FoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJatekosNev1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbJatekosNev2 = new System.Windows.Forms.TextBox();
            this.cbValaszto1 = new System.Windows.Forms.ComboBox();
            this.cbValaszto2 = new System.Windows.Forms.ComboBox();
            this.btnJatekKezdes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(179, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "TicTacToe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(57, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Játékos1:";
            // 
            // tbJatekosNev1
            // 
            this.tbJatekosNev1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbJatekosNev1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbJatekosNev1.Location = new System.Drawing.Point(163, 106);
            this.tbJatekosNev1.Name = "tbJatekosNev1";
            this.tbJatekosNev1.Size = new System.Drawing.Size(129, 26);
            this.tbJatekosNev1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Játékos1:";
            // 
            // tbJatekosNev2
            // 
            this.tbJatekosNev2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbJatekosNev2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbJatekosNev2.Location = new System.Drawing.Point(163, 151);
            this.tbJatekosNev2.Name = "tbJatekosNev2";
            this.tbJatekosNev2.Size = new System.Drawing.Size(129, 26);
            this.tbJatekosNev2.TabIndex = 2;
            // 
            // cbValaszto1
            // 
            this.cbValaszto1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbValaszto1.FormattingEnabled = true;
            this.cbValaszto1.Location = new System.Drawing.Point(332, 104);
            this.cbValaszto1.Name = "cbValaszto1";
            this.cbValaszto1.Size = new System.Drawing.Size(66, 28);
            this.cbValaszto1.TabIndex = 3;
            // 
            // cbValaszto2
            // 
            this.cbValaszto2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbValaszto2.FormattingEnabled = true;
            this.cbValaszto2.Location = new System.Drawing.Point(332, 149);
            this.cbValaszto2.Name = "cbValaszto2";
            this.cbValaszto2.Size = new System.Drawing.Size(66, 28);
            this.cbValaszto2.TabIndex = 3;
            // 
            // btnJatekKezdes
            // 
            this.btnJatekKezdes.Location = new System.Drawing.Point(144, 240);
            this.btnJatekKezdes.Name = "btnJatekKezdes";
            this.btnJatekKezdes.Size = new System.Drawing.Size(273, 79);
            this.btnJatekKezdes.TabIndex = 4;
            this.btnJatekKezdes.Text = "Játék kezdése";
            this.btnJatekKezdes.UseVisualStyleBackColor = true;
            this.btnJatekKezdes.Click += new System.EventHandler(this.btnJatekKezdes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(569, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // FoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(569, 443);
            this.ControlBox = false;
            this.Controls.Add(this.btnJatekKezdes);
            this.Controls.Add(this.cbValaszto2);
            this.Controls.Add(this.cbValaszto1);
            this.Controls.Add(this.tbJatekosNev2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbJatekosNev1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJatekosNev1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbJatekosNev2;
        private System.Windows.Forms.ComboBox cbValaszto1;
        private System.Windows.Forms.ComboBox cbValaszto2;
        private System.Windows.Forms.Button btnJatekKezdes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

