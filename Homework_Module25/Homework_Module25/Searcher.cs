using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public sealed class Searcher
    {
        public IEnumerable<Job> FullSearchByPerson(Person person, List<Job> jobs)
        {
            var eligibleJobs = jobs.Where(x => (x.Sex == null || x.Sex == person.Sex))
                                   .Where(x => person.LocationPreferances.Contains(x.Location))
                                   .Where(x => person.JobPreferences.Intersect(x.Preferences).Any())
                                   .Where(x => x.Profession == person.Profession)
                                   .Where(x => ((person.GetYears() > x.StartAge || x.StartAge == null)
                                                    && (person.GetYears() < x.EndAge || x.EndAge == null)));

            return eligibleJobs;
        }

        public IEnumerable<Person> FullSearchByJob(Job job, List<Person> persons)
        {
            var eligiblePersons = persons.Where(x => (job.Sex == null || x.Sex == job.Sex))
                                      .Where(x => x.LocationPreferances.Contains(job.Location))
                                      .Where(x => x.JobPreferences.Intersect(job.Preferences).Any())
                                      .Where(x => x.Profession == job.Profession)
                                      .Where(x => ((x.GetYears() > job.StartAge || job.StartAge == null)
                                                    && (x.GetYears() < job.EndAge || job.EndAge == null)));

            return eligiblePersons;
        }

        public void WriteSexCount(List<Person> persons)
        {
            var count = persons.GroupBy(x => x.Sex).Select(x => new
            {
                Sex = x.Key,
                Count = x.Count()
            });

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Sex} - {item.Count}");
            }
        }

        public void WriteSuitableProfessions(List<Person> persons, List<Job> jobs)
        {
            var join = persons.Join(jobs,
                       person => person.Profession,
                       job => job.Profession,
                       (person, job) => new
                       {
                           person.FirstName,
                           person.LastName,
                           job.Profession,
                           job.Location
                       });

            foreach (var item in join)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.Profession} {item.Location}");
            }
        }
    }
}
