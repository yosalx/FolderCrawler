namespace BingSlamet
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ouputPanel = new System.Windows.Forms.Panel();
            this.TextStartingDir = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textTimeElapsed = new System.Windows.Forms.Label();
            this.foreground = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.browseFolderBaru = new System.Windows.Forms.Button();
            this.audioOnKeren = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonbaru = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.tombolOffkeren = new System.Windows.Forms.Button();
            this.foreground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1425, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find First";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 266);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.MinimumSize = new System.Drawing.Size(212, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 33);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Type Filename";
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1425, 288);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 64);
            this.button2.TabIndex = 6;
            this.button2.Text = "Find All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select--",
            "BFS",
            "DFS"});
            this.comboBox1.Location = new System.Drawing.Point(12, 310);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(276, 38);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Click_OnMouseDown);
            // 
            // ouputPanel
            // 
            this.ouputPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ouputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ouputPanel.Location = new System.Drawing.Point(12, 360);
            this.ouputPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ouputPanel.Name = "ouputPanel";
            this.ouputPanel.Size = new System.Drawing.Size(1647, 574);
            this.ouputPanel.TabIndex = 8;
            // 
            // TextStartingDir
            // 
            this.TextStartingDir.AutoSize = true;
            this.TextStartingDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.TextStartingDir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextStartingDir.ForeColor = System.Drawing.Color.Black;
            this.TextStartingDir.Location = new System.Drawing.Point(298, 208);
            this.TextStartingDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextStartingDir.Name = "TextStartingDir";
            this.TextStartingDir.Size = new System.Drawing.Size(12, 50);
            this.TextStartingDir.TabIndex = 11;
            this.TextStartingDir.Text = "\r\n\r\n";
            // 
            // textTimeElapsed
            // 
            this.textTimeElapsed.AutoSize = true;
            this.textTimeElapsed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.textTimeElapsed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTimeElapsed.ForeColor = System.Drawing.Color.Black;
            this.textTimeElapsed.Location = new System.Drawing.Point(1350, 945);
            this.textTimeElapsed.Name = "textTimeElapsed";
            this.textTimeElapsed.Size = new System.Drawing.Size(151, 25);
            this.textTimeElapsed.TabIndex = 12;
            this.textTimeElapsed.Text = "Time Elapsed: ";
            // 
            // foreground
            // 
            this.foreground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.foreground.Controls.Add(this.button4);
            this.foreground.Controls.Add(this.button3);
            this.foreground.Controls.Add(this.browseFolderBaru);
            this.foreground.Controls.Add(this.audioOnKeren);
            this.foreground.Controls.Add(this.pictureBox1);
            this.foreground.Controls.Add(this.buttonbaru);
            this.foreground.Controls.Add(this.label1);
            this.foreground.Controls.Add(this.pictureBox5);
            this.foreground.Controls.Add(this.linkBox);
            this.foreground.Controls.Add(this.label3);
            this.foreground.Controls.Add(this.label2);
            this.foreground.Controls.Add(this.TextStartingDir);
            this.foreground.Controls.Add(this.comboBox1);
            this.foreground.Controls.Add(this.button1);
            this.foreground.Controls.Add(this.button2);
            this.foreground.Controls.Add(this.textBox2);
            this.foreground.Controls.Add(this.Logo);
            this.foreground.Controls.Add(this.tombolOffkeren);
            this.foreground.Location = new System.Drawing.Point(4, 0);
            this.foreground.Margin = new System.Windows.Forms.Padding(4);
            this.foreground.Name = "foreground";
            this.foreground.Size = new System.Drawing.Size(1662, 980);
            this.foreground.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::BingSlamet.Properties.Resources.FindAll;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.button4.Location = new System.Drawing.Point(1425, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 64);
            this.button4.TabIndex = 25;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::BingSlamet.Properties.Resources.FindFirst;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.button3.Location = new System.Drawing.Point(1425, 208);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 64);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // browseFolderBaru
            // 
            this.browseFolderBaru.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("browseFolderBaru.BackgroundImage")));
            this.browseFolderBaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.browseFolderBaru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseFolderBaru.FlatAppearance.BorderSize = 0;
            this.browseFolderBaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseFolderBaru.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.browseFolderBaru.Location = new System.Drawing.Point(8, 187);
            this.browseFolderBaru.Name = "browseFolderBaru";
            this.browseFolderBaru.Size = new System.Drawing.Size(282, 74);
            this.browseFolderBaru.TabIndex = 23;
            this.browseFolderBaru.UseVisualStyleBackColor = true;
            this.browseFolderBaru.Click += new System.EventHandler(this.button3_Click);
            // 
            // audioOnKeren
            // 
            this.audioOnKeren.BackgroundImage = global::BingSlamet.Properties.Resources.audioOn;
            this.audioOnKeren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.audioOnKeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audioOnKeren.FlatAppearance.BorderSize = 0;
            this.audioOnKeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.audioOnKeren.Location = new System.Drawing.Point(1601, 50);
            this.audioOnKeren.Name = "audioOnKeren";
            this.audioOnKeren.Size = new System.Drawing.Size(57, 48);
            this.audioOnKeren.TabIndex = 21;
            this.audioOnKeren.UseVisualStyleBackColor = true;
            this.audioOnKeren.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::BingSlamet.Properties.Resources.dex1wrp_2e67ad59_681c_473e_8afd_f60a1ff504c6;
            this.pictureBox1.Location = new System.Drawing.Point(648, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // buttonbaru
            // 
            this.buttonbaru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.buttonbaru.BackgroundImage = global::BingSlamet.Properties.Resources.Button;
            this.buttonbaru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonbaru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonbaru.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.buttonbaru.FlatAppearance.BorderSize = 0;
            this.buttonbaru.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.buttonbaru.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.buttonbaru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonbaru.ForeColor = System.Drawing.Color.Transparent;
            this.buttonbaru.Location = new System.Drawing.Point(1619, 6);
            this.buttonbaru.Name = "buttonbaru";
            this.buttonbaru.Size = new System.Drawing.Size(32, 36);
            this.buttonbaru.TabIndex = 20;
            this.buttonbaru.UseVisualStyleBackColor = false;
            this.buttonbaru.Click += new System.EventHandler(this.buttonbaru_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bing Slamet Folder Crawling";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BingSlamet.Properties.Resources.Rectangle_332;
            this.pictureBox5.Location = new System.Drawing.Point(-6, -11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1709, 66);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.pictureBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // linkBox
            // 
            this.linkBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.linkBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.linkBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.linkBox.FormattingEnabled = true;
            this.linkBox.ItemHeight = 30;
            this.linkBox.Location = new System.Drawing.Point(431, 270);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(602, 64);
            this.linkBox.TabIndex = 18;
            this.linkBox.SelectedIndexChanged += new System.EventHandler(this.link_Click);
            this.linkBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Click_OnMouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(786, 481);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Path Found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(298, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Path Found:";
            // 
            // Logo
            // 
            this.Logo.Image = global::BingSlamet.Properties.Resources.lologoan;
            this.Logo.Location = new System.Drawing.Point(-12, -4);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(368, 248);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            // 
            // tombolOffkeren
            // 
            this.tombolOffkeren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tombolOffkeren.BackgroundImage")));
            this.tombolOffkeren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tombolOffkeren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tombolOffkeren.FlatAppearance.BorderSize = 0;
            this.tombolOffkeren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tombolOffkeren.Location = new System.Drawing.Point(1601, 50);
            this.tombolOffkeren.Name = "tombolOffkeren";
            this.tombolOffkeren.Size = new System.Drawing.Size(57, 48);
            this.tombolOffkeren.TabIndex = 22;
            this.tombolOffkeren.UseVisualStyleBackColor = true;
            this.tombolOffkeren.Click += new System.EventHandler(this.tombolOffkeren_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(106)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1670, 984);
            this.Controls.Add(this.textTimeElapsed);
            this.Controls.Add(this.ouputPanel);
            this.Controls.Add(this.foreground);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.foreground.ResumeLayout(false);
            this.foreground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox2;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
        private ComboBox comboBox1;
        public Panel ouputPanel;
        private Label TextStartingDir;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label textTimeElapsed;
        private Panel foreground;
        private Label label1;
        private PictureBox Logo;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private ListBox linkBox;
        private PictureBox pictureBox5;
        private Button buttonbaru;
        private Button audioOnKeren;
        private Button tombolOffkeren;
        private Button browseFolderBaru;
        private Button button4;
        private Button button3;
    }
}