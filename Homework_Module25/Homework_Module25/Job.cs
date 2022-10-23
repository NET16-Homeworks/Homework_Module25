using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Enums;

namespace Homework_Module25
{
    internal class Job
    {
        public string Location { get; set; }

        public List<string> Preferences { get; set; }

        public Sex? Sex { get; set; }

        public Nullable<int> StartAge { get; set; }

        public Nullable<int> EndAge { get; set; }

        public string Profession { get; set; }
    }
}
