using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.utils
{
    public class Credentials
    {
        public string user;
        public string password;
        public string server;

        public Credentials(string user, string password, string server)
        {
            this.server = server;
            this.password = password;
            this.user = user;
        }
    }
}
