namespace WindowsFormsApp1
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.x1Text = new System.Windows.Forms.TextBox();
            this.y1Text = new System.Windows.Forms.TextBox();
            this.x2Text = new System.Windows.Forms.TextBox();
            this.y2Text = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Aci = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GRAFİK = new System.Windows.Forms.TabPage();
            this.NOT = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.GRAFİK.SuspendLayout();
            this.NOT.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1325, 634);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1221, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "TEST";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // x1Text
            // 
            this.x1Text.Location = new System.Drawing.Point(21, 23);
            this.x1Text.Name = "x1Text";
            this.x1Text.Size = new System.Drawing.Size(100, 20);
            this.x1Text.TabIndex = 3;
            this.x1Text.Text = "180";
            // 
            // y1Text
            // 
            this.y1Text.Location = new System.Drawing.Point(139, 22);
            this.y1Text.Name = "y1Text";
            this.y1Text.Size = new System.Drawing.Size(100, 20);
            this.y1Text.TabIndex = 4;
            this.y1Text.Text = "0";
            // 
            // x2Text
            // 
            this.x2Text.Location = new System.Drawing.Point(21, 49);
            this.x2Text.Name = "x2Text";
            this.x2Text.Size = new System.Drawing.Size(100, 20);
            this.x2Text.TabIndex = 5;
            this.x2Text.Text = "135";
            // 
            // y2Text
            // 
            this.y2Text.Location = new System.Drawing.Point(139, 47);
            this.y2Text.Name = "y2Text";
            this.y2Text.Size = new System.Drawing.Size(100, 20);
            this.y2Text.TabIndex = 6;
            this.y2Text.Text = "135";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(387, 22);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Minimum = -9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(569, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Aci);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.x1Text);
            this.groupBox1.Controls.Add(this.y2Text);
            this.groupBox1.Controls.Add(this.y1Text);
            this.groupBox1.Controls.Add(this.x2Text);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 666);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1339, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1109, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 35);
            this.button2.TabIndex = 9;
            this.button2.Text = "TEST2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Aci
            // 
            this.Aci.Location = new System.Drawing.Point(245, 23);
            this.Aci.Name = "Aci";
            this.Aci.Size = new System.Drawing.Size(100, 20);
            this.Aci.TabIndex = 8;
            this.Aci.Text = "360";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(269, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 628);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(997, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(106, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GRAFİK);
            this.tabControl1.Controls.Add(this.NOT);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1339, 666);
            this.tabControl1.TabIndex = 9;
            // 
            // GRAFİK
            // 
            this.GRAFİK.BackColor = System.Drawing.Color.Black;
            this.GRAFİK.Controls.Add(this.pictureBox1);
            this.GRAFİK.Location = new System.Drawing.Point(4, 22);
            this.GRAFİK.Name = "GRAFİK";
            this.GRAFİK.Padding = new System.Windows.Forms.Padding(3);
            this.GRAFİK.Size = new System.Drawing.Size(1331, 640);
            this.GRAFİK.TabIndex = 0;
            this.GRAFİK.Text = "GRAFİK";
            // 
            // NOT
            // 
            this.NOT.Controls.Add(this.textBox1);
            this.NOT.Location = new System.Drawing.Point(4, 22);
            this.NOT.Name = "NOT";
            this.NOT.Padding = new System.Windows.Forms.Padding(3);
            this.NOT.Size = new System.Drawing.Size(1331, 640);
            this.NOT.TabIndex = 1;
            this.NOT.Text = "NOT";
            this.NOT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 745);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RADAR";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.GRAFİK.ResumeLayout(false);
            this.NOT.ResumeLayout(false);
            this.NOT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox x1Text;
        private System.Windows.Forms.TextBox y1Text;
        private System.Windows.Forms.TextBox x2Text;
        private System.Windows.Forms.TextBox y2Text;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Aci;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GRAFİK;
        private System.Windows.Forms.TabPage NOT;
    }
}

