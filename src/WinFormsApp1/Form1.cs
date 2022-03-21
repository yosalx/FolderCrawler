using Microsoft.Msagl.GraphViewerGdi;

namespace BingSlamet
{
    public partial class Form1 : Form
    {
        GViewer viewer = new GViewer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                listBox1.Items.Clear();
                string dir = label2.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                Search test = new(dir, filename);
                test.bfs_search(0);
                test.makeGraph();
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                label3.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
            else
            {
                listBox1.Items.Clear();
                string dir = label2.Text;
                string filename = textBox2.Text;
                Search test = new(dir, filename);
                test.dfs_search(0);
                test.makeGraph();
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                label3.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                listBox1.Items.Clear();
                string dir = label2.Text;
                string filename = textBox2.Text;
                List<string> vs = new List<string>();
                Search test = new(dir, filename);
                test.bfs_search(1);
                test.makeGraph();
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                label3.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
            }
            else
            {
                listBox1.Items.Clear();
                string dir = label2.Text;
                string filename = textBox2.Text;
                Search test = new(dir, filename);
                test.dfs_search(1);
                test.makeGraph();
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.graph;
                viewer.Dock = DockStyle.Fill;
                label3.Text = "Time Elapsed: " + test.stopwatch.Elapsed.ToString(@"m\:ss\.ffffff");
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
                label2.Text = folderBrowserDialog1.SelectedPath;
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
    }
}