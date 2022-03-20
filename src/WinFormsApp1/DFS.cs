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
        private int i = 0;

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
        private void colorBlueWhenFound(dirTree found)
        {
            dirTree child = found;
            dirTree parent = tree[found.parent_id];
            while (child.parent_id != -999)
            {
                graph.AddEdge(found.name, "BJIRRR");
                graph.AddEdge(parent.name, child.name).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                child = parent;
                dirTree temp = tree[parent.parent_id];
                parent = temp;
            }
        }
        private int findId(string directory)
        {
            for (int j = 0; j < tree.Count(); j++)
            {
                if (tree[0].directory == directory) {
                    return j;
                }
            }
            return -999;
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
                    tree.Add(new dirTree(findId(currDir), Path.GetFileName(content), content, "File", "Found"));
                    done = true;
                    graph.AddEdge(Path.GetFileName(currDir),Path.GetFileName(content)).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                    colorBlueWhenFound(tree[tree.Count() - 1]);
                    if (done && set == 0)
                    {
                        return done;
                    }
                }
                else
                {
                    tree.Add(new dirTree(findId(currDir), Path.GetFileName(content), content, "File", "Not"));
                    graph.AddEdge(Path.GetFileName(currDir), Path.GetFileName(content)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                }
            }

            string[] Dirs = Directory.GetDirectories(currDir,"*",options);
            foreach (string Folder in Dirs)
            {
                tree.Add(new dirTree(findId(currDir), Path.GetFileName(Folder), Folder, "Folder", "Not"));
                graph.AddEdge(Path.GetFileName(currDir), Path.GetFileName(Folder)).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
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
