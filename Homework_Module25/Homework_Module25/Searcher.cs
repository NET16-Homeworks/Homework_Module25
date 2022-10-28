using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Searcher
    {
        public delegate void Messaging(string message);
        public event Messaging? message;

        public void FullSearchByPerson(Person person, List<Job> jobs)
        {
            int age = CalculateAge(person.BirthDate);

            var selectedJobs = jobs
                .Where(q => q.Sex == null || (int)q.Sex == (int)person.Sex)
                .Where(q => person.LocationPreferances == null || person.LocationPreferances.Contains(q.Location))
                .Where(q => (q.StartAge == null || q.StartAge.Value <= age) && (q.EndAge == null || age <= q.EndAge.Value))
                .Where(q => person.JobPreferances == null || q.Preferances.Intersect(person.JobPreferances) != null)
                .Where(q => q.Profession == person.Profession)
                ;

            if (selectedJobs.Any() == true)
            {
                foreach (var job in selectedJobs)
                {
                    message?.Invoke($"Name: {NullToAny(person.FirstName)} {NullToAny(person.LastName)}, Email: {person.Email} | Profession: {NullToAny(job.Profession)}, Location {NullToAny(job.Location)}, by parameters: {EnumerableToString(job.Preferances)}");   
                }
            }
        }

        public void FullSearchByJob(Job job, List<Person> persons)
        {
            var selectedPersons = persons
                .Where(q => job.Sex == null || (int)q.Sex == (int)job.Sex)
                .Where(q => !q.LocationPreferances.Any() || q.LocationPreferances.Contains(job.Location))
                .Where(q => (job.StartAge == null || job.StartAge.Value <= CalculateAge(q.BirthDate)) && (job.EndAge == null || CalculateAge(q.BirthDate) <= job.EndAge.Value))
                .Where(q => !q.JobPreferances.Any() || job.Preferances.Intersect(q.JobPreferances) != null)
                .Where(q => job.Profession == q.Profession);

            if (selectedPersons.Any() == true)
            {
                foreach (var person in selectedPersons)
                {
                    message?.Invoke($"Name: {person.FirstName} {person.LastName}, Email: {person.Email} | Profession: {NullToAny(job.Profession)}, Location {NullToAny(job.Location)}, by parameters: {EnumerableToString(job.Preferances)}");
                }
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
                message?.Invoke($"{person.Name} - count: {person.Count}");
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

        private int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Today.Year - birthDate.Year;
            if (birthDate > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }
}
