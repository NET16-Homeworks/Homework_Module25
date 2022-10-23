using Microsoft.VisualBasic;
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
        public GenderEnum Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> JobPreferences { get; set; } 
        public List<string> LocationPreferances { get; set; }
        public string Profession { get; set; }

        public int BirthDateInAge ( DateTime birthDate)
        {
            DateTime today = DateTime.Today;

            int age = today.Year - birthDate.Year;

            if (birthDate.AddYears(age) > today)
            {
                age--;
            }
            return age;
        }
        public void PrintPerson(Person person)
        {
            string? jobPreference = "";
            string? locationPreferences = "";

            foreach (string item in person.JobPreferences)
                jobPreference = jobPreference + item + " ";

            foreach (string item in person.LocationPreferances)
                locationPreferences = locationPreferences + item + " ";

            Console.WriteLine($"Профессия: {person.Profession} \nИмя: {person.FirstName}\nФамилия: {person.LastName}\nПол: {person.Gender}\nРабочие предпочтения: {jobPreference}\nВозраст: {person.BirthDateInAge(person.BirthDate)}\nEmail: {person.Email}\nПредпочтительные страны: {locationPreferences}");
            Console.WriteLine();
        }
    }
}
