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
            var result = jobs.Where(q => ((q.Gender == person.Gender || q.Gender == null) && 
                                   (person.LocationPreferances.Contains(q.Location)) && 
                                   ((person.BirthDateInAge(person.BirthDate) >= q.StartAge || q.StartAge == 0) && (person.BirthDateInAge(person.BirthDate) <= q.EndAge || q.EndAge == 0)) &&
                                   (person.JobPreferences.Intersect(q.Preferences).Any() == true) &&
                                   (person.Profession == q.Profession)));

            foreach (var job in result)
            {
                job.PrintJob(job);
            }
            
        }

        public void FullSearchByJob(Job job, List<Person> persons)
        {
            var result = persons.Where(q => ((q.Gender == job.Gender || job.Gender == null) &&
                                   (q.LocationPreferances.Contains(job.Location)) &&
                                   ((q.BirthDateInAge(q.BirthDate) >= job.StartAge || job.StartAge == 0) && (q.BirthDateInAge(q.BirthDate) <= job.EndAge || job.EndAge == 0)) &&
                                   (q.JobPreferences.Intersect(job.Preferences).Any() == true) &&
                                   (q.Profession == job.Profession)));
            foreach (var person in result)
            {
                person.PrintPerson(person);
            }

        }

        public void WriteGenderCount(List<Person> persons)
        {
            var groupByGender = persons.GroupBy(q => q.Gender,
                                               (key, enumerable) => new
                                               {
                                                   Gender = key,
                                                   GenderCount = enumerable.Count()
                                               });
            foreach (var item in groupByGender)
                Console.WriteLine(item.Gender + " " + item.GenderCount);
        }

        public void WriteSuitableProfessions(List<Person> persons, List<Job> jobs)
        {
            foreach (var person in persons)
            {
                var filter = jobs.Where(q => ((q.Gender == person.Gender || q.Gender == null) &&
                                   (person.LocationPreferances.Contains(q.Location)) &&
                                   ((person.BirthDateInAge(person.BirthDate) >= q.StartAge || q.StartAge == 0) && (person.BirthDateInAge(person.BirthDate) <= q.EndAge || q.EndAge == 0)) &&
                                   (person.JobPreferences.Intersect(q.Preferences).Any() == true ) &&
                                   (person.Profession == q.Profession)));
                Console.Write($"{person.FirstName} {person.LastName} " );
                foreach (var job in filter)
                {
                    Console.Write($"{job.Profession},{job.Location} ");
                }
                Console.WriteLine();
            }
        }

    }
}
