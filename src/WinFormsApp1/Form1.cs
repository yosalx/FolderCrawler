namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
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
                {
                    listBox1.Items.Add(item.found + "\t" + item.directory);
                }
            }
            else
            {
                listBox1.Items.Clear();
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                DFS test = new DFS(dir, filename);
                test.dfs_search(0);
                foreach (dirTree item in test.getDFSTree())
                {
                    listBox1.Items.Add(item.found + "\t" + item.directory);
                }
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
                foreach (dirTree item in test.getTree())
                {
                    listBox1.Items.Add(item.found + "\t" + item.directory);
                }
            }
            else
            {
                listBox1.Items.Clear();
                string dir = textBox1.Text;
                string filename = textBox2.Text;
                DFS test = new DFS(dir, filename);
                test.dfs_search(1);
                foreach (dirTree item in test.getDFSTree())
                {
                    listBox1.Items.Add(item.found + "\t" + item.directory);
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}