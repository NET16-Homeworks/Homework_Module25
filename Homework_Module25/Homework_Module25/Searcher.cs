using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Searcher
    {
        //человек ищет работу 

        public void FullSearchByPerson(Person person, List<Job> jobs)
        {
            int age = DateTime.Now.Year - person.BirthDate.Year;
            var result = jobs
                    .Where(q => q.Preferences.Intersect(person.JobPreferences) != null)
                    .Where(q => q.Sex == null || q.Sex == person.Sex)
                    .Where(q => person.LocationPreferences == null || person.LocationPreferences.Contains(q.Location))
                    .Where(q => q.Profession == person.Profession)
                    .Where(q => (q.StartAge == null || q.StartAge <= age) &&
                    (q.EndAge == null || q.EndAge >= age));

            foreach (var job in result)
            {
                //не выводит на консоль
                Console.WriteLine($"For the person {person.FirstName}, {person.LastName}" + Environment.NewLine +
                   $"the jobs {job.Profession}, location: {job.Location} are applicable".ToString());
            }
        }

        //работодатель ищет человека на работу:
        public void FullSearchByJob(Job job, List<Person> people)
        {
            Person person = new Person();
            int age = DateTime.Now.Year - person.BirthDate.Year;

            var desiredPerson = people
                .Where(q => q.Sex == job.Sex || job.Sex == null)
                .Where(q => age >= job.StartAge && age <= job.EndAge)
                .Where(q => q.JobPreferences.Intersect(job.Preferences).Any())
                .Where(q => q.LocationPreferences == null || q.LocationPreferences.Contains(job.Location))
                .Where(q => q.Profession == job.Profession);

            foreach (var employee in desiredPerson)
            {
                // не выводит на консоль
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
            // + вывести где м а где ж
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


        //public void JobOutput(Job job)
        //{
        //    string? sex = string.Empty;
        //    if (job.Sex == null)
        //    {
        //        sex = "N/A";
        //    }

        //    else
        //    {
        //        sex = job.Sex.ToString();
        //    }
        //}
    }
}

                
