using Microsoft.Msagl.GraphViewerGdi;
using System.Media;
using System.Diagnostics;

namespace BingSlamet
{
    public partial class Main : Form
    {
        SoundPlayer backgroundSong = new SoundPlayer("./Resources/newbacksound.wav");
        SoundPlayer errorsound = new SoundPlayer("./Resources/errorParah.wav");
        SoundPlayer klikinput = new SoundPlayer("./Resources/mintaInput.wav");
        SoundPlayer ketemu = new SoundPlayer("./Resources/suaraKetemu.wav");
        SoundPlayer start = new SoundPlayer("./Resources/windowsStartup.wav");
        SoundPlayer click = new SoundPlayer("./Resources/click.wav");
        private static List<String> path = new List<String>();
        private static List<Label> links = new List<Label>();

        GViewer viewer = new GViewer();
        public Main()
        {
            start.Play();
            InitializeComponent();
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearhyperlink();
            if (TextStartingDir.Text.ToString() == "\r\n\r\n")
            {
                klikinput.Play();
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                click.Play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                try
                {
                    Search test = new(dir, filename);
                    test.bfs_search(0);
                    test.makeGraph();
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    ouputPanel.SuspendLayout();
                    ouputPanel.Controls.Add(viewer);
                    ouputPanel.ResumeLayout();
                    ouputPanel.Show();
                    viewer.Graph = test.graph;
                    viewer.Dock = DockStyle.Fill;
                    ketemu.Play();
                    textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
                }
                catch { errorsound.Play(); }

            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "DFS")
            {
                click.Play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                try
                {
                    Search test = new(dir, filename);
                    test.dfs_search(0);
                    test.makeGraph();
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    ouputPanel.SuspendLayout();
                    ouputPanel.Controls.Add(viewer);
                    ouputPanel.ResumeLayout();
                    ouputPanel.Show();
                    viewer.Graph = test.graph;
                    viewer.Dock = DockStyle.Fill;
                    ketemu.Play();
                    textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
                }
                catch { errorsound.Play(); }
            }
            else
            {
                klikinput.Play();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearhyperlink();
            if (TextStartingDir.Text.ToString() == "\r\n\r\n")
            {
                klikinput.Play();
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                click.Play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                Search test = new(dir, filename);
                try
                {
                    test.bfs_search(1);
                    test.makeGraph();
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    ouputPanel.SuspendLayout();
                    ouputPanel.Controls.Add(viewer);
                    ouputPanel.ResumeLayout();
                    ouputPanel.Show();
                    viewer.Graph = test.graph;
                    viewer.Dock = DockStyle.Fill;
                    ketemu.Play();
                    textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
                }
                catch { errorsound.Play(); }
            }
            else if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "DFS")
            {
                click.Play();
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                try
                {

                    Search test = new(dir, filename);
                    test.dfs_search(1);
                    test.makeGraph();
                    path = new List<string>();
                    path = test.dir_found;
                    makeLinks(path);
                    ouputPanel.SuspendLayout();
                    ouputPanel.Controls.Add(viewer);
                    ouputPanel.ResumeLayout();
                    ouputPanel.Show();
                    viewer.Graph = test.graph;
                    viewer.Dock = DockStyle.Fill;
                    ketemu.Play();
                    textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
                }
                catch { errorsound.Play(); }
            }
            else
            {
                klikinput.Play();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() != "--Select--")
                {
                click.Play();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
            click.Play();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                TextStartingDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Type Filename")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Type Filename";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void foreground_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void windowsBar_Paint(object sender)
        {

        }
        private bool mouseDown;
        private Point lastLocation;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void audioOn_Click(object sender, EventArgs e)
        {
            backgroundSong.Play();
            audioOff.Visible = true;
            audioOn.Visible = false;
        }

        private void audioOff_Click(object sender, EventArgs e)
        {
            backgroundSong.Stop();
            audioOff.Visible = false;
            audioOn.Visible = true;
        }
        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;

        }

        private void makeLinks(List<String> path)
        {
            List<Label> links = new List<Label>();
            int vertical = 0;
            if (path.Count == 0)
            {
                Label test = new Label();
                Controls.Add(test);
                test.Font = new Font("Tahoma", 7, FontStyle.Underline, GraphicsUnit.Point);
                test.ForeColor = Color.Black;
                test.Location = new Point(473, 167);
                test.Name = "text";
                test.Size = new Size(430, 32);
                test.TabIndex = 16;
                test.Text = "No Path Found";
                test.TextAlign = ContentAlignment.MiddleLeft;
            }
            else
            {
                foreach (String item in path)
                {
                    Label link = new Label();
                    Controls.Add(link);
                    link.Font = new Font("Tahoma", 7, FontStyle.Underline, GraphicsUnit.Point);
                    link.ForeColor = Color.Black;
                    link.Location = new Point(296, 167 + vertical * 25);
                    link.Name = item;
                    link.BackColor = Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(216)))));
                    link.Size = new Size(430, 32);
                    link.TabIndex = 16;
                    link.Text = item;
                    link.TextAlign = ContentAlignment.MiddleLeft;
                    link.Click += new EventHandler(hyperlink_Click);
                    link.BringToFront();
                    links.Add(link);
                    vertical++;
                }
            }
        }

        private void clearhyperlink()
        {
            foreach (Label link in links)
            {
                link.Text = "";
            }

        }
        private void hyperlink_Click(object sender, EventArgs e)
        {
            Label link = sender as Label;
            string path = link.Text.Substring(0, link.Text.LastIndexOf('\\'));
            Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = path,
                UseShellExecute = true,
                Verb = "open"
            });
        }
    }
}