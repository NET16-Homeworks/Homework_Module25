using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Searcher
    {
        public void FullSearchByPerson(Person person, List<Job> jobs)
        {   
            int age = DateTime.Today.Year - person.BirthDate.Year;
            if (person.BirthDate > DateTime.Today.AddYears(-age)) age--;

            var Selectedjobs = jobs
                .Where(q => q.Sex == null || (int)q.Sex == (int)person.Sex)
                .Where(q => person.LocationPreferances == null || person.LocationPreferances.Contains(q.Location))
                .Where(q => (q.StartAge == null || q.StartAge.Value <= age) && (q.EndAge == null || age <= q.EndAge.Value))
                .Where(q => person.JobPreferances == null || q.Preferances.Intersect(person.JobPreferances) != null)
                .Where(q => person.Profession != null && q.Profession == person.Profession)
                ;

            if (Selectedjobs.Any() == true)
            {
                foreach (var job in Selectedjobs)
                {
                    Console.WriteLine($"Name: {NullToAny(person.FirstName)} {NullToAny(person.LastName)} | Profession: {NullToAny(job.Profession)}, Location {NullToAny(job.Location)}, by parameters: {EnumerableToString(job.Preferances)}");   
                }
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
