using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Seacher
    {
        public static List<Job> FullSearchByPerson(Person person, List<Job> listOfJobs)
        {
            int age = DateTime.Now.Year - person.BirthDate.Year;
            var resultList = listOfJobs
                    .Where(q => q.Sex == null || q.Sex == person.Sex)
                    .Where(q => (age >= q.StartAge && age <= q.EndAge) || (q.StartAge == null || q.EndAge == null))
                    .Where(q => q.Preferences.Intersect(person.JobPreferences).Any())
                    .Where(q => person.LocationPreferences == null || person.LocationPreferences.Contains(q.Location))
                    .Where(q => q.Profession == person.Profession)
                    .ToList();
            return resultList;
        }

        public static List<Person> FullSearchByJob(Job job, List<Person> listOfPersons)
        {
            var resultList = listOfPersons
                    .Where(q => job.Sex == null || q.Sex == job.Sex)
                    .Where(q => ((job.StartAge < (DateTime.Now.Year - q.BirthDate.Year)) && (job.EndAge > (DateTime.Now.Year - q.BirthDate.Year))) || (job.StartAge == null || job.EndAge == null))
                    .Where(q => q.JobPreferences.Intersect(job.Preferences).Any())
                    .Where(q => q.LocationPreferences == null || q.LocationPreferences.Contains(job.Location))
                    .Where(q => q.Profession == job.Profession)
                    .ToList();
            return resultList;
        }

        public static void WriteSexCount(List<Person> listOfPersons)
        {
            var result = listOfPersons
                    .GroupBy(p => p.Sex)
                    .Select(g => new { Sex = g.Key, Count = g.Count() });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Sex} : {item.Count}");
            }
        }

        public static void WriteSuitableProfessions(List<Person> listOfPersons, List<Job> listOfJobs)
        {
            var result = listOfPersons.Join(listOfJobs, q => q.Profession, w => w.Profession,
                (q, w) => new
                {
                    FirstName = q.FirstName,
                    LastName = q.LastName,
                    Profession = w.Profession,
                    Location = w.Location
                });

            foreach (var item in result)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} претендует на {item.Profession} в  {item.Location}");
            }
        }
    }
}
