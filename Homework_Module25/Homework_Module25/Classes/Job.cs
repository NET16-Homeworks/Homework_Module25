using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Helper;

namespace Homework_Module25
{
    public class Job
    {
        public string Location { get; set; }

        public string Preferences { get; set; }

        public SexEnum? Sex { get; set; }

        public int? StartAge { get; set; }

        public int? EndAge { get; set; }

        public string Profession { get; set; }
    }
}
