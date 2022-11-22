using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Helper;

namespace Homework_Module25
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public SexEnum Sex { get; set; }

        public DateTime BirthDate { get; set; }

        public List<string> JobPreferences { get; set; }

        public List<string> LocationPreferances { get; set; }

        public string Profession { get; set; }
    }
}
