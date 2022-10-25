using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25;


namespace Homework_Module25
{
    internal class Searcher
    {
       
        public void FullSearchByPerson(Person person, List<Job> jobs)
        {
            var result = jobs.Where(q => ((q.Sex == person.Sex || q.Sex == null) &&
                                    (person.LocationPreferances.Contains(q.Location)) &&
                                    ((person.BirthDayInAge(person.BirthDate) >= q.StartAge || q.StartAge == 0) && (person.BirthDayInAge(person.BirthDate) <= q.EndAge || q.EndAge == 0)) &&
                                    (person.JobPreferences.Intersect(q.Preferences) != null) &&
                                    (person.Profession == q.Profession)));

            foreach (var job in result)
            {
                job.PrintJob(job);
            }
        }
        public void FullSearchByJob(Job job, List<Person> persons)
        {
            List<Job> jobAsList = new List<Job>();
            jobAsList.Add(job);
            foreach (var person in persons)
            {
                FullSearchByPerson(person, jobAsList);
            }
        }

        public void WriteSexCount(List<Person> persons)
        {
            var groupedPersons = persons.GroupBy(q => q.Sex).Select(q =>
                                                                    new
                                                                    {
                                                                        Name = q.Key,
                                                                        Count = q.Count(),
                                                                    });
            foreach (var person in groupedPersons)
            {
                Console.WriteLine($"{person.Name} - count: {person.Count}");
            }
        }

        public void WriteSuiatableProfessions(List<Person> persons, List<Job> jobs)
        {
            foreach (var person in persons)
            {
                FullSearchByPerson(person, jobs);
            }
        }

        private string NullToAny<T>(T value)
        {
            if (value == null)
            {
                return "Any";
            }
            else
            {
                return value.ToString();
            }
        }

        private string EnumerableToString(List<string> list)
        {
            string result = String.Empty;
            foreach (var item in list)
            {
                result += $"{item}, ";
            }
            return result.Remove(result.Length - 2);
        }
    }
}

