using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25.Helper
{
    public static class PersonInitialization
    {
        public static Person InitializeNewPerson()
        {
            var person = new Person()
            {
                FirstName = "Pasha",
                LastName = "Gamezo",
                Email = "p@gmail.com",
                BirthDate = new DateTime(2002, 9, 23),
                JobPreferences = new List<string>()
                {
                    "Full time",
                    "Part time"
                },
                LocationPreferances = new List<string>()
                {
                    "Poland",
                    "Georgia"
                },
                Profession = "Programmer (.Net developer)",
                Sex = SexEnum.Man
            };

            return person;
        }

        public static List<Person> InitializePeopleList()
        {
            var people = new List<Person>()
            {
                new Person()
                {
                    FirstName = "Pasha", 
                    LastName = "Gamezo", 
                    Email = "p@gmail.com", 
                    BirthDate = new DateTime(2002, 9, 23),
                    JobPreferences = new List<string>()
                    {
                        "Full time",
                        "Part time"
                    },
                    LocationPreferances = new List<string>()
                    {
                        "Belarus"
                    },
                    Profession = "Programmer (.Net developer)",
                    Sex = SexEnum.Man
                },
                new Person()
                { 
                    FirstName = "Ivan", 
                    LastName = "Ivanov", 
                    Email = "sho@gmail.com", 
                    BirthDate = new DateTime(2000, 10, 20),
                    JobPreferences = new List<string>()
                    {
                        "Full time",
                        "Part time"
                    },
                    LocationPreferances = new List<string>()
                    {
                        "Belarus"
                    },
                    Profession = "Administrator",
                    Sex = SexEnum.Man
                },
                new Person()
                {
                    FirstName = "Elena", 
                    LastName = "Pupkina", 
                    Email = "ep@gmail.com", 
                    BirthDate = new DateTime(1995, 01, 13),
                    JobPreferences = new List<string>()
                    {
                        "Full time",
                    },
                    LocationPreferances = new List<string>()
                    {
                        "Ukraine"
                    },
                    Profession = "Doctor",
                    Sex = SexEnum.Woman
                },
                new Person()
                { 
                    FirstName = "Anton", 
                    LastName = "Antonov", 
                    Email = "mriya@gmail.com", 
                    BirthDate = new DateTime(1995, 01, 13),
                    JobPreferences = new List<string>()
                    {
                        "Full time",
                    },
                    LocationPreferances = new List<string>()
                    {
                        "Belarus"
                    },
                    Profession = "Doctor",
                    Sex = SexEnum.Woman
                }
            };

            return people;
        }
    }
}
