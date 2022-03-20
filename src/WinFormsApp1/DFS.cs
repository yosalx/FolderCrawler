using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace WinFormsApp1
{
    public class DFS
    {
        private string startdir;
        private string filename;
        private List<dirTree> tree;
        private Graph graph;

        public DFS(string startdir, string filename)
        {
            this.startdir = @startdir;
            this.filename = filename;
            tree = new List<dirTree>();
            graph = new Graph();
        }
        public List<dirTree> getDFSTree()
        {
            return this.tree;
        }
        public Graph getGraph()
        {
            return this.graph;
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
                    tree[findIdbyName(tree[j].name)].name += " (" + tree[tree[findIdbyName(tree[j].name)].parent_id].name + ")";
                    tree[j].name += " (" + tree[tree[j].parent_id].name + ")";
                }
                if (tree[j].found == "Found")
                {
                    graph.AddEdge(tree[tree[j].parent_id].name, tree[j].name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                }
                else
                {
                    graph.AddEdge(tree[tree[j].parent_id].name, tree[j].name).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
                j--;
            }
        }
        public bool reccursion(string currDir, int set, bool done)
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
                tree.Add(new dirTree(findIdbyDir(currDir), Path.GetFileName(Folder), Folder, "Folder", "Not"));
                done = reccursion(Folder, set, done);
                if (done && set == 0)
                {
                    return done;
                }
            }
            return done;
        }

        public void dfs_search(int set)
        {
            try
            {
                tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir, "Folder", "Not"));
                bool done = false;
                reccursion(tree[0].directory, set, done);
            }
            catch { }
        }
    }
}
