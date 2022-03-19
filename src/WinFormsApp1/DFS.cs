using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinFormsApp1
{
    public class DFS
    {
        private string startdir;
        private string filename;
        private List<dirTree> tree;

        public DFS(string startdir, string filename)
        {
            this.startdir = @startdir;
            this.filename = filename;
            tree = new List<dirTree>();
        }
        public List<dirTree> getDFSTree()
        {
            return this.tree;
        }

        public bool reccursion(string currDir, int set, bool done)
        {
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true,
                AttributesToSkip = FileAttributes.System
            };
            int i = 0;

            string[] files = Directory.GetFiles(currDir,"*.*",options);
                
            foreach(string content in files){
                if ((currDir + "\\" + filename) == content)
                {
                    tree.Add(new dirTree(i, Path.GetFileName(content), content, "File", "Found"));
                    done = true;
                    if (done && set == 0)
                    {
                        return done;
                    }
                }
                else
                {
                    tree.Add(new dirTree(i, Path.GetFileName(content), content, "File", "Not"));
                }
            }

            string[] Dirs = Directory.GetDirectories(currDir,"*",options);
            foreach (string Folder in Dirs)
            {
                tree.Add(new dirTree(i, Path.GetFileName(Folder), Folder, "Folder", "Not"));
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
