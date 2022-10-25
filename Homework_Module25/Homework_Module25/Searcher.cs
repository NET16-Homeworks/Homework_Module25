using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal static class Searcher
    {
        public static IEnumerable<Job> FullSearchByPerson(Person person, List<Job> listWithJobs)
        {
            var personAge = DateTime.Now.Year - person.BirthDate.Year;
            var resultList = listWithJobs
                    .Where(q => q.Sex == null || q.Sex == person.Sex)
                    .Where(q => person.LocationPreferances.Contains(q.Location))
                    .Where(q => (personAge >= q.StartAge && personAge <= q.EndAge) || (q.StartAge == null || q.EndAge == null))
                    .Where(q =>
                    {
                        var isContainPreference = false;
                        foreach (var preferencesPerson in person.JobPreferances)
                        {
                            isContainPreference = q.Preferances.Any(q => q == preferencesPerson);
                            if (isContainPreference)
                            {
                                return isContainPreference;
                            }
                        }
                        return false;
                    })
                    .Where(q => q.Profession == person.Profession);
            return resultList;
        }

        public static IEnumerable<Person> FullSearchByJob(Job job, List<Person> listWithPersons)
        {
            var resultList = listWithPersons
                    .Where(q => job.Sex == null || q.Sex == job.Sex)
                    .Where(q => (job.StartAge == null || job.EndAge == null) || (job.StartAge < (DateTime.Now.Year - q.BirthDate.Year)) && (job.EndAge > (DateTime.Now.Year - q.BirthDate.Year)))
                    .Where(q =>
                    {
                        var isContainPreference = false;
                        foreach (var preferencesJob in job.Preferances)
                        {
                            isContainPreference = q.JobPreferances.Any(q => q == preferencesJob);
                            if (isContainPreference)
                            {
                                return isContainPreference;
                            }
                        }
                        return false;
                    })
                    .Where(q => q.LocationPreferances.Contains(job.Location))
                    .Where(q => q.Profession == job.Profession);
            return resultList;
        }

        public static void WriteSexCount(List<Person> listWithPersons)
        {
            var printSexAndCountOfUsers = listWithPersons.GroupBy(q => q.Sex).Select(q => new
            {
                Sex = q.Key,
                CountOfUsers = q.Count()
            });
            foreach (var item in printSexAndCountOfUsers)
            {
                Console.WriteLine($"{item.Sex} - {item.CountOfUsers}");
            }
        }

        public static void WriteSuitableProfessions(List<Person> listWithPersons, List<Job> listWithJobs)
        {
            IEnumerable<Job> jobs;
            foreach (var person in listWithPersons)
            {
                jobs = listWithJobs.Where(q=>q.Profession == person.Profession);
                foreach(var job in jobs)
                {
                    Console.WriteLine(@$"FirstName: {person.FirstName}" + Environment.NewLine + 
                                       $"LastName: {person.LastName}" + Environment.NewLine + 
                                       $"Profession: {job.Profession}" + Environment.NewLine + 
                                       $"Location: {job.Location}" + Environment.NewLine + 
                                        "=======================================");
                }
            }
        }
    }
}
