using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class StatModel
    {
        public string stat { get; set; }
        public string table { get; set; }
        public bool autoCreate { get; set; }
        public int days { get; set; }
        public DateTime updateDate { get; set; }
        public string database { get; set; }
        public string script { get; set; }
    }
}
