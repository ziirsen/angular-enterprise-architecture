using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEA.LoadTester
{
    public class CompareModel
    {
        public int BytesSent { get; set; }
        public int BytesRecevied { get; set; }
        public int TimeTaken { get; set; }
        public string LogName { get; set; }
    }
}
