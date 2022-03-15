using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1
{
    public class BFS
    {
        private string startdir;
        private string filename;
        private List<dirTree> tree;

        public BFS(string startdir, string filename)
        {
            this.startdir = @startdir;
            this.filename = filename;
            tree = new List<dirTree>();
        }
        public List<dirTree> getTree()
        {
            return this.tree;
        }
        public void search(int set)
        {
            int i = 0;
            bool found = false;
            tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir,"Folder","Not"));
            string parentdir = startdir;
            while (i < tree.Count())
            {
                try
                {
                    List<string> temptree = Directory.GetFiles(tree[i].directory).ToList();
                    foreach (string a in temptree)
                    {
                        if ((tree[i].directory + "\\" + filename) == a)
                        {
                            tree.Add(new dirTree(i, Path.GetFileName(a), a, "File","Found"));
                            found = true;
                        }
                        else
                        {
                            tree.Add(new dirTree(i, Path.GetFileName(a), a, "File", "Not"));
                        }
                    }
                    if (set == 0 && found)
                    {
                        break;
                    }
                    temptree = Directory.GetDirectories(tree[i].directory).ToList(); ;
                    foreach (string a in temptree)
                    {
                        tree.Add(new dirTree(i, Path.GetFileName(a), a, "Folder", "Not"));
                    }
                    i++;
                    parentdir = tree[i].directory;
                    while (tree[i].type == "File" && i < tree.Count())
                    {
                        i++;
                        parentdir = tree[i].directory;
                    }
                }
                catch { }
            }
        }
    }
}
