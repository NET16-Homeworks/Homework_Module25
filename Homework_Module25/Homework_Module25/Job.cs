using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Job
    {
        public string Location { get; set; }
        public List<string> Preferances { get; set; }
        public Sex? Sex { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public string Profession { get; set; }
    }
}
