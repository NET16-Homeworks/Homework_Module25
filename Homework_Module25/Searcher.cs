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
            var result = jobs
                    .Where(q => person.JobPreferences.Intersect(q.Preferences).Any())
                    .Where(q => q.Sex == null || q.Sex == person.Sex)
                    .Where(q => person.LocationPreferences == null || person.LocationPreferences.Contains(q.Location))
                    .Where(q => q.Profession == person.Profession)
                    .Where(q => (q.StartAge == null || q.StartAge <= person.Age()) &&
                    (q.EndAge == null || q.EndAge >= person.Age()));

            foreach (var job in result)
            {               
                Console.WriteLine($"For the person {person.FirstName}, {person.LastName}" + Environment.NewLine +
                   $"the jobs {job.Profession}, location: {job.Location} are applicable".ToString());
            }
        }
        public void FullSearchByJob(Job job, List<Person> people)
        {
            var desiredPerson = people
                .Where(q => q.Sex == job.Sex || job.Sex == null)
                .Where(q => q.Age() >= job.StartAge && q.Age() <= job.EndAge)
                .Where(q => q.JobPreferences.Intersect(job.Preferences).Any())
                .Where(q => q.LocationPreferences == null || q.LocationPreferences.Contains(job.Location))
                .Where(q => q.Profession == job.Profession);

            foreach (var employee in desiredPerson)
            {
                Console.WriteLine($"The people {employee.FirstName}, {employee.LastName}, {employee.Email}" + Environment.NewLine +
                    $"are suitable for the job {job.Profession}.".ToString());
            }
        }
        public void WriteSexCount(List<Person> people)
        {
            var result = people.GroupBy(q => q.Sex)
                .Select(s => new
                {
                    Sex = s.Key,
                    Count = s.Count()
                });

            foreach (var res in result)
            {
                Console.WriteLine($"{res.Sex} | {res.Count}");
            }
        }
        public void WriteSuitableProfessions(List<Person> people, List<Job> jobs)
        {
            var result = people.Join(jobs, p => p.Profession, j => j.Profession,
                (p, j) => new
                {
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Profession = j.Profession,
                    Location = j.Location
                });

            foreach (var res in result)
            {
                Console.WriteLine($"FirstName: {res.FirstName}, LastName = {res.LastName}"
                                  + Environment.NewLine +
                                  $"Profession = {res.Profession}, Location = {res.Location}");
            }
        }
    }
}

                
