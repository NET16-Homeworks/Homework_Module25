using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace Homework_Module25
{
    public static class Searcher
    {
        public static IEnumerable<Job> FullSearchByPerson(Person person, List<Job> jobs)
        {
            var personAge = ((DateTime.Now - person.BirthDate).Days) / 365;
            var results = jobs.Where(job => job.Sex == person.Sex || job.Sex == null)
                        .Where(job => job.Preferences == person.JobPreferences.FirstOrDefault(personPreference => personPreference == job.Preferences))
                        .Where(job => job.Location == person.LocationPreferances.FirstOrDefault(personLocation => personLocation == job.Location))
                        .Where(job => job.Profession == person.Profession)
                        .Where(job => job.StartAge is null || job.StartAge <= personAge)
                        .Where(job => job.EndAge is null || job.EndAge >= personAge);

            return results;
        }
        
        public static IEnumerable<Person> FullSearchByJob(List<Person> people, Job job) // ????
        {
            var results = people.Where(people => people.Sex == job.Sex)
                        .Where(person => person.JobPreferences.Any(preferences => preferences == job.Preferences))
                        .Where(person => person.LocationPreferances.Any(location => location == job.Location))
                        .Where(person => person.Profession == job.Profession)
                        .Where(person => ((DateTime.Now - person.BirthDate).Days) / 365 >= job.StartAge)
                        .Where(person => ((DateTime.Now - person.BirthDate).Days) / 365 <= job.EndAge);

            return results;
        }

        public static void WriteSexCount(List<Person> people)
        {
            var results = people.GroupBy(person => person.Sex);

            foreach (var item in results)
            {
                Console.WriteLine($"Value {item.Key} - {item.Count()}");
                foreach (var person in item)
                {
                    Console.WriteLine($"{person.FirstName} {person.LastName} - {person.Profession}");
                }
            }
        }

        public static void WriteSuitableProfession(List<Person> people, List<Job> jobs)
        {
            var result = people.Join(jobs,
                        person => person.Profession,
                        job => job.Profession,
                        (person, job) => new
                        {
                            FirstName = person.FirstName,
                            LastName = person.LastName,
                            Profession = job.Profession,
                            Location = job.Location
                        });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.LastName} {item.LastName} - {item.Profession}, {item.Location}");
            }
        }
    }
}
