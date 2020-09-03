using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class DatabaseModel
    {
        public int databaseId { get; set; }
        public int serverId { get; set; }
        public int name { get; set; }
        public DateTime updateDate { get; set; }
    }
}
