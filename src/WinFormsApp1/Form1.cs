using Microsoft.Msagl.GraphViewerGdi;
using System.Media;

namespace BingSlamet
{
    public partial class Main : Form
    {
        SoundPlayer backgroundSong = new SoundPlayer("./Resources/Backsound.wav");
        GViewer viewer = new GViewer();
        public Main()
        {
            InitializeComponent();
            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            //            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            backgroundSong.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                Search test = new(dir, filename);
                test.bfs_search(0);
                test.makeGraph();
                ouputPanel.SuspendLayout();
                ouputPanel.Controls.Add(viewer);
                ouputPanel.ResumeLayout();
                ouputPanel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
            else
            {
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                Search test = new(dir, filename);
                test.dfs_search(0);
                test.makeGraph();
                ouputPanel.SuspendLayout();
                ouputPanel.Controls.Add(viewer);
                ouputPanel.ResumeLayout();
                ouputPanel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                Search test = new(dir, filename);
                test.bfs_search(1);
                test.makeGraph();
                ouputPanel.SuspendLayout();
                ouputPanel.Controls.Add(viewer);
                ouputPanel.ResumeLayout();
                ouputPanel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
            else
            {
                string dir = TextStartingDir.Text;
                string filename = textBox2.Text;
                Search test = new(dir, filename);
                test.dfs_search(1);
                test.makeGraph();
                ouputPanel.SuspendLayout();
                ouputPanel.Controls.Add(viewer);
                ouputPanel.ResumeLayout();
                ouputPanel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                textTimeElapsed.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}

        private void panel1_Paint(object sender, PaintEventArgs e)
        {}

        private void button3_Click(object sender, EventArgs e)
        {
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
                textBox2.ForeColor = Color.White;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Type Filename";
                textBox2.ForeColor = Color.White;
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
    }
}