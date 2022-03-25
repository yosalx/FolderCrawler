using System.Diagnostics;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace BingSlamet
{
    public class Search
    {
        public string startdir;
        public string filename;
        public List<dirTree> tree;
        public List<string> dir_found;
        public Graph graph;
        public Stopwatch stopwatch;

        public Search(string startdir, string filename)
        {
            this.startdir = @startdir;
            this.filename = filename;
            tree = new List<dirTree>();
            graph = new Graph();
            stopwatch = new Stopwatch();
            dir_found = new List<string>();
        }
        private void makeAllFound(dirTree found)
        {
            int j = found.parent_id;
            while (tree[j].parent_id != -999)
            {
                tree[j].found = "Found";
                j = tree[j].parent_id;
            }
        }

        private int findIdbyDir(string directory)
        {
            for (int j = 0; j < tree.Count(); j++)
            {
                if (tree[j].directory == directory) {
                    return j;
                }
            }
            return -999;
        }

        private int findIdbyName(string name)
        {
            for (int j = 0; j < tree.Count(); j++)
            {
                if (tree[j].name == name)
                {
                    return j;
                }
            }
            return -999;
        }

        private void changeBlueToRoot(string nodename)
        {
            string node = nodename;
            while (graph.FindNode(node).InEdges.Count() > 0)
            {
                graph.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                graph.FindNode(node).InEdges.Last().Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                node = graph.FindNode(node).InEdges.Last().SourceNode.Id;
            }
            graph.FindNode(node).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
        }

        private string createNode(string name, int parent)
        {
            if (findIdbyName(name) != -999)
            {
                string nodename = (name + " (" + this.tree[parent].name + ")");
                graph.AddNode(nodename);
                return nodename;
            }
            else
            {
                graph.AddNode(name);
                return name;
            }
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        public bool dfs_reccursion(string currDir, int set, bool done)
        {
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true,
                AttributesToSkip = FileAttributes.System
            };

            string[] files = Directory.GetFiles(currDir,"*",options);
                
            foreach(string content in files){
                if (Path.GetFileName(content) == this.filename)
                {
                    wait(100);
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(content), content, "File", "Found", createNode(Path.GetFileName(content), findIdbyDir(currDir))));
                    graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                    graph.AddEdge(tree[tree.Last().parent_id].nodename, tree.Last().nodename).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    Program.F1.viewer.Graph = graph;
                    Program.F1.ouputPanel.SuspendLayout();
                    Program.F1.viewer.Dock = DockStyle.Fill;
                    Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                    Program.F1.ouputPanel.ResumeLayout();
                    Program.F1.ouputPanel.Show();
                    done = true;
                    changeBlueToRoot(tree.Last().nodename);
                    dir_found.Add(content);
                    if (done && set == 0)
                    {
                        return done;
                    }
                }
                else
                {
                    wait(100);
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(content), content, "File", "Not", createNode(Path.GetFileName(content), findIdbyDir(currDir))));
                    graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    graph.AddEdge(tree[tree.Last().parent_id].nodename, tree.Last().nodename).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    Program.F1.viewer.Graph = graph;
                    Program.F1.ouputPanel.SuspendLayout();
                    Program.F1.viewer.Dock = DockStyle.Fill;
                    Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                    Program.F1.ouputPanel.ResumeLayout();
                    Program.F1.ouputPanel.Show();
                }
            }
            string[] Dirs = Directory.GetDirectories(currDir,"*",options);
            foreach (string Folder in Dirs)
            {
                if (done && set == 0)
                {
                    wait(100);
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(Folder), Folder, "Folder", "Queued", createNode(Path.GetFileName(Folder), findIdbyDir(currDir))));
                    graph.FindNode(tree.Last().nodename);
                    graph.AddEdge(tree[tree.Last().parent_id].nodename, Path.GetFileName(Folder));
                    Program.F1.viewer.Graph = graph;
                    Program.F1.ouputPanel.SuspendLayout();
                    Program.F1.viewer.Dock = DockStyle.Fill;
                    Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                    Program.F1.ouputPanel.ResumeLayout();
                    Program.F1.ouputPanel.Show();
                }
                else
                {
                    wait(100);
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(Folder), Folder, "Folder", "Not", createNode(Path.GetFileName(Folder), findIdbyDir(currDir))));
                    graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    graph.AddEdge(tree[tree.Last().parent_id].nodename, Path.GetFileName(Folder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    Program.F1.viewer.Graph = graph;
                    Program.F1.ouputPanel.SuspendLayout();
                    Program.F1.viewer.Dock = DockStyle.Fill;
                    Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                    Program.F1.ouputPanel.ResumeLayout();
                    Program.F1.ouputPanel.Show();
                    done = dfs_reccursion(Folder, set, done);
                }
            }
            return done;
        }

        public void dfs_search(int set)
        {
            Program.F1.viewer.Graph = graph;
            stopwatch.Start();
            try
            {
                wait(100);
                tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir, "Folder", "Not", Path.GetFileName(startdir)));
                graph.AddNode(tree.Last().nodename);
                graph.FindNode(tree.First().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                Program.F1.viewer.Graph = graph;
                Program.F1.ouputPanel.SuspendLayout();
                Program.F1.viewer.Dock = DockStyle.Fill;
                Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                Program.F1.ouputPanel.ResumeLayout();
                Program.F1.ouputPanel.Show();
                bool done = false;
                dfs_reccursion(tree.First().directory, set, done);
            }
            catch { }

            stopwatch.Stop();
        }

        public void bfs_search(int set)
        {
            stopwatch.Start();
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true,
                AttributesToSkip = FileAttributes.System
            };
            int i = 0;
            bool found = false;
            tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir, "Folder", "Not", Path.GetFileName(startdir)));
            graph.AddNode(tree.Last().nodename);
            graph.FindNode(tree.First().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            Program.F1.viewer.Graph = graph;
            Program.F1.ouputPanel.SuspendLayout();
            Program.F1.viewer.Dock = DockStyle.Fill;
            Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
            Program.F1.ouputPanel.ResumeLayout();
            Program.F1.ouputPanel.Show();
            string parentdir = startdir;
            while (i < tree.Count())
            {
                List<string> temptree = Directory.GetFiles(tree[i].directory, "*", options).ToList();
                foreach (string a in temptree)
                {
                    if ((Path.GetFileName(a) == this.filename))
                    {
                        wait(100);
                        tree.Add(new dirTree(i, Path.GetFileName(a), a, "File", "Found", createNode(Path.GetFileName(a), i)));
                        graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                        graph.AddEdge(tree[i].nodename, tree.Last().nodename).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                        found = true;
                        changeBlueToRoot(tree.Last().nodename);
                        Program.F1.viewer.Graph = graph;
                        Program.F1.ouputPanel.SuspendLayout();
                        Program.F1.viewer.Dock = DockStyle.Fill;
                        Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                        Program.F1.ouputPanel.ResumeLayout();
                        Program.F1.ouputPanel.Show();
                        dir_found.Add(a);
                    }
                    else
                    {
                        wait(100);
                        tree.Add(new dirTree(i, Path.GetFileName(a), a, "File", "Not", createNode(Path.GetFileName(a), i)));
                        graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        graph.AddEdge(tree[i].nodename, tree.Last().nodename).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        Program.F1.viewer.Graph = graph;
                        Program.F1.ouputPanel.SuspendLayout();
                        Program.F1.viewer.Dock = DockStyle.Fill;
                        Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                        Program.F1.ouputPanel.ResumeLayout();
                        Program.F1.ouputPanel.Show();
                    }
                }
                if (set == 0 && found)
                {
                    return;
                }
                temptree = Directory.GetDirectories(tree[i].directory, "*", options).ToList();
                foreach (string a in temptree)
                {
                    wait(100);
                    tree.Add(new dirTree(i, Path.GetFileName(a), a, "Folder", "Not", createNode(Path.GetFileName(a), i)));
                    graph.FindNode(tree.Last().nodename).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    graph.AddEdge(tree[i].nodename, tree.Last().nodename).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    Program.F1.viewer.Graph = graph;
                    Program.F1.ouputPanel.SuspendLayout();
                    Program.F1.viewer.Dock = DockStyle.Fill;
                    Program.F1.ouputPanel.Controls.Add(Program.F1.viewer);
                    Program.F1.ouputPanel.ResumeLayout();
                    Program.F1.ouputPanel.Show();
                }
                try
                {
                    i++;
                    parentdir = tree[i].directory;
                    while (tree[i].type == "File" && i < tree.Count())
                    {
                        i++;
                        parentdir = tree[i].directory;
                    }
                }
                catch { break; }
            }
            stopwatch.Stop();
        }
    }
}
