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

        public void dfs_search(int set)
        {
            var options = new EnumerationOptions()
            {
                IgnoreInaccessible = true,
                AttributesToSkip = FileAttributes.System
            };
            int i = 0;
            bool found = false;
            tree.Add(new dirTree(-999, Path.GetFileName(startdir), startdir,"Folder","Not"));

            Stack<string> dir = new Stack<string>(9999);
            dir.Push(startdir);
            
            while(dir.Count > 0){
                string currDir = dir.Pop();
                string[] files;

                files = Directory.GetFiles(currDir,"*.*",options);
                
                foreach(string content in files){
                    if ((currDir + "\\" + filename) == content)
                    {
                        tree.Add(new dirTree(i, Path.GetFileName(content), content, "File", "Found"));
                        found = true;
                    }
                    else
                    {
                        tree.Add(new dirTree(i, Path.GetFileName(content), content, "File", "Not"));
                    }
                }
                if (set == 0 && found)
                {
                    break;
                }
                string[] Dirs;
                Dirs = Directory.GetDirectories(currDir,"*",options);
                foreach (string Folder in Dirs)
                {
                    tree.Add(new dirTree(i, Path.GetFileName(Folder), Folder, "Folder", "Not"));
                    dir.Push(Folder);
                }
            }
        }
    }
}
