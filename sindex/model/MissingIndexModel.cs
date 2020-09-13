using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class MissingIndexModel
    {
        public string database { get; set; }
        public string table { get; set; }
        public double impact { get; set; }
        public DateTime lastSeek { get; set; }
        public string scriptIndex { get; set; }
    }
}
