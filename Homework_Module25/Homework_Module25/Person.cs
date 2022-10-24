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
        private string firstName;
        private string lastName;
        public string FirstName { get { return firstName ?? "John"; } set { firstName = value; } }
        public string LastName { get { return lastName ?? "Doe"; } set { lastName = value; } }
        public string Email { get { return email ?? "Not declared"; } set { email = value; } }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string>? JobPreferances { get; set; }
        public List<string>? LocationPreferances { get; set; }
        public string Profession { get; set; }
    }
}
