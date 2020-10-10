using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class TopQueryModel
    {
        public DateTime createTime { get; set; }
        public DateTime lastExecutionDateTime { get; set; }
        public double totalWokerTime { get; set; }
        public double avgCpuTime { get; set; }
        public int avgPhysicalReads { get; set; }
        public int avgLogicalWrites { get; set; }
        public double avgElapsedTime { get; set; }
        public int executionCount { get; set; }
        public string query { get; set; }
        public string plan { get; set; }
        public string databaseName { get; set; }
        public int avgUsedThreads { get; set; }
        public int avgMaxDop { get; set; }
        public string statement { get; set; }
    }
}
