using Bogus;
using Homework_Module25.Constants;
using Homework_Module25.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public sealed class VirtualDB
    {
        private static List<Person>? _persons;
        private static List<Job>? _jobs;

        public void CreateDB()
        {
            var random = new Random();
            var jobPreferences = JobPreferences.jobPreferences;
            var locationPreferences = LocationPreferences.locationPreferences;
            var professions = Professions.professions;

            //create List<Person>
            var personFaker = new Faker<Person>()
                .RuleFor(x => x.FirstName, faker => faker.Person.FirstName)
                .RuleFor(x => x.LastName, faker => faker.Person.LastName)
                .RuleFor(x => x.Email, faker => faker.Person.Email)
                .RuleFor(x => x.BirthDate, faker => faker.Person.DateOfBirth);
            _persons = personFaker.Generate(100);

            foreach (var person in _persons)
            {
                person.Sex = Enum.Parse<Sex>(random.Next(0, 2).ToString());
                person.Profession = professions[random.Next(0, professions.Count)];

                for (int i = 0; i < 3; i++)
                {
                    person.JobPreferences
                        .Add(jobPreferences[random.Next(0, jobPreferences.Count)]);
                    person.LocationPreferances
                        ?.Add(locationPreferences[random.Next(0, locationPreferences.Count)]);
                }
            }

            //create List<Job>
            var jobFaker = new Faker<Job>();
            _jobs = jobFaker.Generate(100);

            foreach (var job in _jobs)
            {
                int sexRandom = random.Next(0, 3);
                if (sexRandom == 2)
                {
                    job.Sex = null;
                }
                else
                {
                    job.Sex = Enum.Parse<Sex>(sexRandom.ToString());
                }

                for (int i = 0; i < 3; i++)
                {
                    job.Preferences
                        .Add(jobPreferences[random.Next(0, jobPreferences.Count)]);
                }

                job.Location = locationPreferences[random.Next(0, locationPreferences.Count)];
                job.Profession = professions[random.Next(0, professions.Count)];

                int ageRandom = random.Next(0, 3);
                if (ageRandom == 2)
                {
                    job.StartAge = null;
                    job.EndAge = random.Next(40,50);
                }
                else if (ageRandom == 1)
                {
                    job.StartAge = random.Next(16, 25);
                    job.EndAge = null;
                }
                else
                {
                    job.StartAge = random.Next(16, 25);
                    job.EndAge = random.Next(40, 50);
                }
            }
        }

        public List<Person>? GetPersons()
        {
            return _persons;
        }

        public List<Job>? GetJobs()
        {
            return _jobs;
        }
    }
}
