using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Person
    {
        private string email;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get { return email ?? "Not declared"; } set { email = value; } }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> JobPreferances { get; set; }
        public List<string> LocationPreferances { get; set; }
        public string Profession { get; set; }
    }
}
