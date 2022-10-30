using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static Homework_Module25.Job;
using Homework_Module25.Enums;
using Homework_Module25.Const;
using Bogus;

namespace Homework_Module25
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public SexEnum Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public List<string> JobPreferences { get; set; } = new();
        public List<string> LocationPreferences { get; set; } = new();
        public string Profession { get; set; }

        public static void PrintPersonInfo(Person person)
        {
            Console.WriteLine($@"Name: {person.FirstName} {person.LastName};"+$"{Environment.NewLine}"+
                   $"Email: {person.Email}; "+$"{ Environment.NewLine}"+
                    $"Sex: {person.Sex};"+$"{Environment.NewLine}"+
                    $"BirthDay: {person.BirthDate};"+$"{Environment.NewLine}"+
                    $"Profession: {person.Profession};"+$"{Environment.NewLine}"+
                    $"JobPreferences: {String.Join(", ", person.JobPreferences.ToArray())};"+$"{Environment.NewLine}" +
                    $"LocationPreferences: {String.Join(", ", person.LocationPreferences.ToArray())};");
        }

        
    }
}
