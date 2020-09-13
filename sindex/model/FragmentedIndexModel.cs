using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class FragmentedIndexModel
    {
        public string table { get; set; }
        public string database { get; set; }
        public string index { get; set; }
        public double fragmentation { get; set; }
        public string type { get; set; }
        public string script { get; set; }
    }
}
