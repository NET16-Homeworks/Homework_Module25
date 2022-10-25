using Homework_Module25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp 
{
    
    internal class Program
    {
        static Random RND = new Random();
        

        public void PrintPerson(Person person)
        {
            string? jobPreference = "";
            string? locationPreferences = "";

            foreach (string item in person.JobPreferences)
                jobPreference = jobPreference + item + " ";

            foreach (string item in person.LocationPreferances)
                locationPreferences = locationPreferences + item + " ";

            Console.WriteLine($"Профессия: {person.Profession} " +
                $"\nИмя: {person.FirstName}\nФамилия: {person.LastName}" +
                $"\nПол: {person.Sex}" +
                $"\nРабочие предпочтения: {jobPreference}\nВозраст: {person.BirthDayInAge(person.BirthDate)}" +
                $"\nEmail: {person.Email}\nПредпочтительные страны: {locationPreferences}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
                List<Person> persons = new List<Person>()
                 {
                     new Person()
                          {
                                FirstName = "Dmitriy",
                                LastName = "Danenkov",
                                Sex =SexEnum.Man,
                                Email = "Cooler426@Gmail.com",
                                LocationPreferances = new List<string>() { "Grodno", "Brest", "Minsk" },
                                BirthDate = new DateTime(1999, 03, 09),
                                Profession = "CSS/Java Developer",
                                JobPreferences = new List<string>() { "Home", "Office", "Free" },
                            },
                     new Person()
                            {
                                FirstName = "Dasha",
                                LastName = "Lomeiko",
                                Sex = SexEnum.Woman,
                                Email = "DashaL@Gmail.com",
                                LocationPreferances = new List<string>() { "Brest","Gomel" },
                                BirthDate = new DateTime(2003, 11, 03),
                                Profession = "Banker",
                                JobPreferences = new List<string>() { "Home", "Free" },
                            },
                     new Person()
                            {
                            FirstName = "Valeriy",
                            LastName = "Vacovskiy",
                            Sex = SexEnum.Man,
                            Email = "ValeraThreeGuns@Gmail.com",
                            LocationPreferances = new List<string>() { "Vitebsk", "Minsk" },
                            BirthDate = new DateTime(2001, 06, 06),
                            Profession = "Streamer",
                            JobPreferences = new List<string>() { "Home", "Free", "Office"},
                            },
                     new Person()
                           {
                        FirstName = "Antonida",
                        LastName = "Petrovna",
                        Sex = SexEnum.Woman,
                        Email = "Antonida221@Gmail.com",
                        LocationPreferances = new List<string>() { "Minsk" },
                        BirthDate = new DateTime(2006, 12, 07),
                        Profession = "Translate-master",
                        JobPreferences = new List<string>() { "Office" },
                          },
                };
            List<Job> jobs = new List<Job>()
                 {
                        new Job()
                        {
                            Sex=SexEnum.Man,
                            Location = "Minsk",
                            StartAge=17,
                            EndAge=54,
                            Preferences = new List<string> () {"Office"},
                            Profession = "Streamer"
                        },
                        new Job()
                        {
                            Sex=SexEnum.Woman,
                            Location = "Gomel",
                            StartAge=21,
                            EndAge=55,
                            Preferences = new List<string> () {"Home"},
                            Profession = "IT-specialist"
                        },
                        new Job()
                        {
                            Sex =SexEnum.Man,
                            Location = "Grodno",
                            StartAge = null,
                            EndAge = 47,
                            Preferences = new List<string> (){"Free"},
                            Profession = "IT Teacher"
                        },
                        new Job()
                        {
                            Sex =SexEnum.Woman,
                            Location = "Minsk",
                            StartAge = 22,
                            EndAge = null,
                            Preferences = new List<string> (){"Office", "Free","Home"},
                            Profession = "UX/UI Programmer"
                        }
                };

            Searcher searcher = new Searcher();

            Console.WriteLine("Job By Person");
            searcher.FullSearchByPerson(persons[2], jobs);

            Console.WriteLine("Person by job");
            searcher.FullSearchByJob(jobs[1], persons);

            Console.WriteLine("Counter of Sex");
            searcher.WriteSexCount(persons);

            Console.WriteLine("Suitable Professions");
            searcher.WriteSuiatableProfessions(persons, jobs);
        }
    }
}