using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace WinFormsApp1
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
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                BFS test = new BFS(dir, filename);
                test.bfs_search(0);
                foreach (dirTree item in test.getTree())
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.getGraph();
                viewer.Dock = DockStyle.Fill;
            }
            else
            {
                listBox1.Items.Clear();
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                DFS test = new DFS(dir, filename);
                test.dfs_search(0);
                foreach (dirTree item in test.getDFSTree())
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.getGraph();
                viewer.Dock = DockStyle.Fill;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items[comboBox1.SelectedIndex].ToString() == "BFS")
            {
                listBox1.Items.Clear();
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                BFS test = new BFS(dir, filename);
                test.bfs_search(1);
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.getGraph();
                viewer.Dock = DockStyle.Fill;
            }
            else
            {
                listBox1.Items.Clear();
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                DFS test = new DFS(dir, filename);
                test.dfs_search(1);
                panel.SuspendLayout();
                panel.Controls.Add(viewer);
                panel.ResumeLayout();
                panel.Show();
                viewer.Graph = test.getGraph();
                viewer.Dock = DockStyle.Fill;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}