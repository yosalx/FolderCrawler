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
            this.button3 = new System.Windows.Forms.Button();
            this.TextStartingDir = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textTimeElapsed = new System.Windows.Forms.Label();
            this.labelHyperlink = new System.Windows.Forms.LinkLabel();
            this.foreground = new System.Windows.Forms.Panel();
            this.audioOn = new System.Windows.Forms.PictureBox();
            this.audioOff = new System.Windows.Forms.PictureBox();
            this.windowsBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.foreground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioOff)).BeginInit();
            this.windowsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(950, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find First";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(8, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.MinimumSize = new System.Drawing.Size(143, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Type Filename";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(950, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "Find All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "--Select--",
            "BFS",
            "DFS"});
            this.comboBox1.Location = new System.Drawing.Point(8, 207);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ouputPanel
            // 
            this.ouputPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ouputPanel.Location = new System.Drawing.Point(8, 240);
            this.ouputPanel.Name = "ouputPanel";
            this.ouputPanel.Size = new System.Drawing.Size(1098, 382);
            this.ouputPanel.TabIndex = 8;
            this.ouputPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(5, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 49);
            this.button3.TabIndex = 9;
            this.button3.Text = "Browse Folder";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TextStartingDir
            // 
            this.TextStartingDir.AutoSize = true;
            this.TextStartingDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.TextStartingDir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextStartingDir.ForeColor = System.Drawing.Color.Black;
            this.TextStartingDir.Location = new System.Drawing.Point(199, 139);
            this.TextStartingDir.Name = "TextStartingDir";
            this.TextStartingDir.Size = new System.Drawing.Size(8, 36);
            this.TextStartingDir.TabIndex = 11;
            this.TextStartingDir.Text = "\r\n\r\n";
            // 
            // textTimeElapsed
            // 
            this.textTimeElapsed.AutoSize = true;
            this.textTimeElapsed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.textTimeElapsed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTimeElapsed.ForeColor = System.Drawing.Color.Black;
            this.textTimeElapsed.Location = new System.Drawing.Point(900, 624);
            this.textTimeElapsed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textTimeElapsed.Name = "textTimeElapsed";
            this.textTimeElapsed.Size = new System.Drawing.Size(105, 18);
            this.textTimeElapsed.TabIndex = 12;
            this.textTimeElapsed.Text = "Time Elapsed: ";
            // 
            // labelHyperlink
            // 
            this.labelHyperlink.AutoSize = true;
            this.labelHyperlink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.labelHyperlink.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHyperlink.Location = new System.Drawing.Point(8, 624);
            this.labelHyperlink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHyperlink.Name = "labelHyperlink";
            this.labelHyperlink.Size = new System.Drawing.Size(68, 18);
            this.labelHyperlink.TabIndex = 13;
            this.labelHyperlink.TabStop = true;
            this.labelHyperlink.Text = "linkLabel1";
            this.labelHyperlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // foreground
            // 
            this.foreground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
            this.foreground.Controls.Add(this.label2);
            this.foreground.Controls.Add(this.audioOn);
            this.foreground.Controls.Add(this.audioOff);
            this.foreground.Controls.Add(this.windowsBar);
            this.foreground.Controls.Add(this.TextStartingDir);
            this.foreground.Controls.Add(this.button3);
            this.foreground.Controls.Add(this.comboBox1);
            this.foreground.Controls.Add(this.button1);
            this.foreground.Controls.Add(this.button2);
            this.foreground.Controls.Add(this.textBox2);
            this.foreground.Controls.Add(this.Logo);
            this.foreground.Location = new System.Drawing.Point(3, 0);
            this.foreground.Name = "foreground";
            this.foreground.Size = new System.Drawing.Size(1108, 653);
            this.foreground.TabIndex = 14;
            this.foreground.Paint += new System.Windows.Forms.PaintEventHandler(this.foreground_Paint);
            // 
            // audioOn
            // 
            this.audioOn.Image = global::WinFormsApp1.Properties.Resources.audioOn;
            this.audioOn.Location = new System.Drawing.Point(1049, 35);
            this.audioOn.Name = "audioOn";
            this.audioOn.Size = new System.Drawing.Size(42, 36);
            this.audioOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.audioOn.TabIndex = 13;
            this.audioOn.TabStop = false;
            this.audioOn.Click += new System.EventHandler(this.audioOn_Click);
            // 
            // audioOff
            // 
            this.audioOff.Image = ((System.Drawing.Image)(resources.GetObject("audioOff.Image")));
            this.audioOff.Location = new System.Drawing.Point(1049, 35);
            this.audioOff.Name = "audioOff";
            this.audioOff.Size = new System.Drawing.Size(42, 36);
            this.audioOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.audioOff.TabIndex = 14;
            this.audioOff.TabStop = false;
            this.audioOff.Click += new System.EventHandler(this.audioOff_Click);
            // 
            // windowsBar
            // 
            this.windowsBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.windowsBar.Controls.Add(this.label1);
            this.windowsBar.Controls.Add(this.closeButton);
            this.windowsBar.Location = new System.Drawing.Point(-8, 0);
            this.windowsBar.Name = "windowsBar";
            this.windowsBar.Size = new System.Drawing.Size(1121, 29);
            this.windowsBar.TabIndex = 0;
            this.windowsBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.windowsBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.windowsBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(229)))));
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.4F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Bing Slamet Folder Crawling";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::WinFormsApp1.Properties.Resources.Button;
            this.closeButton.Location = new System.Drawing.Point(1091, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(21, 24);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 2;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::WinFormsApp1.Properties.Resources.lologoan;
            this.Logo.Location = new System.Drawing.Point(-8, -3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(245, 165);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 12;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(208, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Path Found";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1113, 656);
            this.Controls.Add(this.labelHyperlink);
            this.Controls.Add(this.textTimeElapsed);
            this.Controls.Add(this.ouputPanel);
            this.Controls.Add(this.foreground);
            this.ForeColor = System.Drawing.Color.BlueViolet;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.foreground.ResumeLayout(false);
            this.foreground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.audioOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioOff)).EndInit();
            this.windowsBar.ResumeLayout(false);
            this.windowsBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
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
        private Panel ouputPanel;
        private Button button3;
        private Label TextStartingDir;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label textTimeElapsed;
        private LinkLabel labelHyperlink;
        private Panel foreground;
        private Panel windowsBar;
        private PictureBox closeButton;
        private Label label1;
        private PictureBox Logo;
        private PictureBox audioOff;
        private PictureBox audioOn;
        private Label label2;
    }
}