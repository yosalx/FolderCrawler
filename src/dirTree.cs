using Microsoft.Msagl.Drawing;

namespace BingSlamet
{
    public class dirTree
    {
        public int parent_id;
        public string name;
        public string directory;
        public string type;
        public string found;
        public string nodename;

        public dirTree(int parent_id, string name, string directory, string type, string found, string nodename)
        {
            this.parent_id = parent_id;
            this.name = name;
            this.directory = directory;
            this.type = type;
            this.found = found;
            this.nodename = nodename;
        }
    }

}
