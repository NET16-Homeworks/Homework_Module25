using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Homework_Module25.Job;

namespace Homework_Module25
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public SexEnum Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> JobPreferences { get; set; }
        public List<string> LocationPreferances { get; set; }
        public string Profession { get; set; }

        public int BirthDayInAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.AddYears(age) > today)
            {
                age--;
            }
            return age;
        }
    }
}
