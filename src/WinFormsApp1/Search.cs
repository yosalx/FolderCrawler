using System.Diagnostics;
using Microsoft.Msagl.Drawing;

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

        public void makeGraph()
        {
            int j = tree.Count() - 1;
            while (j != 0)
            {
                if (findIdbyName(tree[j].name) != j)
                {
                    try
                    {
                        tree[findIdbyName(tree[j].name)].name = tree[findIdbyName(tree[j].name)].name + " (" + tree[tree[findIdbyName(tree[j].name)].parent_id].name + ")";
                    } catch { }
                    tree[j].name += " (" + tree[tree[j].parent_id].name + ")";
                }
                if (tree[j].found == "Found")
                {
                    graph.AddEdge(tree[tree[j].parent_id].name, tree[j].name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    graph.FindNode(tree[j].name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                    graph.FindNode(tree[tree[j].parent_id].name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                }
                else if (tree[j].found == "Queued")
                {
                    graph.AddEdge(tree[tree[j].parent_id].name, tree[j].name).Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
                }
                else
                {
                    graph.AddEdge(tree[tree[j].parent_id].name, tree[j].name).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                    graph.FindNode(tree[j].name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    if (graph.FindNode(tree[tree[j].parent_id].name).Attr.FillColor != Microsoft.Msagl.Drawing.Color.Blue)
                    {

                        graph.FindNode(tree[tree[j].parent_id].name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
                j--;
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
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(content), content, "File", "Found"));
                    done = true;
                    makeAllFound(tree[tree.Count() - 1]);
                    dir_found.Add(content);
                    if (done && set == 0)
                    {
                        return done;
                    }
                }
                else
                {
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(content), content, "File", "Not"));
                }
            }
            string[] Dirs = Directory.GetDirectories(currDir,"*",options);
            foreach (string Folder in Dirs)
            {
                if (done && set == 0)
                {
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(Folder), Folder, "Folder", "Queued"));
                }
                else
                {
                    tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(Folder), Folder, "Folder", "Not"));
                    done = dfs_reccursion(Folder, set, done);
                }
            }
            return done;
        }

        public void dfs_search(int set)
        {
            stopwatch.Start();
            try
            {
                tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir, "Folder", "Not"));
                bool done = false;
                dfs_reccursion(tree[0].directory, set, done);
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
            tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir, "Folder", "Not"));
            string parentdir = startdir;
            while (i < tree.Count())
            {
                List<string> temptree = Directory.GetFiles(tree[i].directory, "*", options).ToList();
                foreach (string a in temptree)
                {
                    if ((Path.GetFileName(a) == this.filename))
                    {
                        tree.Add(new dirTree(i, Path.GetFileName(a), a, "File", "Found"));
                        found = true;
                        makeAllFound(tree[tree.Count() - 1]);
                        dir_found.Add(a);
                    }
                    else
                    {
                        tree.Add(new dirTree(i, Path.GetFileName(a), a, "File", "Not"));
                    }
                }
                if (set == 0 && found)
                {
                    return;
                }
                temptree = Directory.GetDirectories(tree[i].directory, "*", options).ToList();
                foreach (string a in temptree)
                {
                    tree.Add(new dirTree(i, Path.GetFileName(a), a, "Folder", "Not"));
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
