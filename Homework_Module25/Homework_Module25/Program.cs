using Bogus;
using Homework_Module25.Enums;
using System.Collections.Concurrent;

namespace Homework_Module25
{
    public class Programm
    {
        public static void Main(string[] args)
        {
            var virtualDB = new VirtualDB();
            virtualDB.CreateDB();

            var persons = virtualDB.GetPersons();
            var jobs = virtualDB.GetJobs();

            var seacher = new Searcher();
            var jobsForPerson = seacher.FullSearchByPerson(persons[0], jobs);
            var personsForJob = seacher.FullSearchByJob(jobs[0], persons);

            Console.WriteLine(persons[0]);
            foreach (var job in jobsForPerson)
            {
                Console.WriteLine(job);
            }

            Console.WriteLine(jobs[0]);
            foreach (var person in personsForJob)
            {
                Console.WriteLine(person);
            }

            seacher.WriteSuitableProfessions(persons, jobs);
            seacher.WriteSexCount(persons);

            Console.WriteLine();
        }
    }
}