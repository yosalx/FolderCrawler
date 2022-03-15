using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class dirTree
    {
        public int parent_id;
        public string name;
        public string directory;
        public string type;
        public string found;

        public dirTree(int parent_id, string name, string directory, string type, string found)
        {
            this.parent_id = parent_id;
            this.name = name;
            this.directory = directory;
            this.type = type;
            this.found = found;
        }
    }

}
