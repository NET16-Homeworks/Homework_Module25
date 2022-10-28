using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public class Job
    {
        public List<string>? Location = new List<string>();
        
        public List<string>? Preferences = new List<string>();  
        public Const.sex? Sex { get; set; }

        public int? StartAge {get; set;}

        public int? EndAge {get; set;}

        public string Profession { get; set; }
    }
}
