
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class SessionModel
    {
        public int sessionId { get; set; }
        public string databaseName { get; set; }
        public string hostName { get; set; }
        public string programName { get; set; }
        public string clientInterfaceName { get; set; }
        public int blockingSessionId { get; set; }
        public int openTransacionCount { get; set; }
        public double percentComplete { get; set; }
        public int cpuTime { get; set; }
        public int totalElapsedTime { get; set; }
        public int reads { get; set; }
        public int writes { get; set; }
        public int logicalReads { get; set; }
        public DateTime startTime { get; set; }
        public string status { get; set; }
        public string waitType { get; set; }
        public int waitTime { get; set; }
        public string waitResource { get; set; }
        public string command { get; set; }
        public string currentStatement { get; set; }
        public string cmdSql { get; set; }
        public string qryPlan { get; set; }
    }
}
