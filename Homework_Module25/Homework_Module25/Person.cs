using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public DateOnly BirthDate { get; set; }
        public List<string> JobPreferances { get; set; }
        public List<string> LocationPreferances { get; set; }
        public string Profession { get; set; }
    }
}
