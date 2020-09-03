using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class ConfigurationModel
    {
        public int configurationId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime updateDate { get; set; }
        public string value { get; set; }

    }
}
