using Homework_Module25.Enums;
using Homework_Module25.Classes;

namespace Homework_Module25.Classes
{
    public class Searcher
    {
        public List<Job> FullSearchByPerson(Person person, List<Job> jobList)
        {
            return jobList
                .Where(job => job.Profession == person.Profession)
                .Where(job => job.Sex == person.Sex || job.Sex == null)
                .Where(job => job.Location.Intersect(person.LocationPreferences).Any())
                .Where(job => job.Preferences.Intersect(person.JobPreferences).Any())
                .Where(job => VerifyAge(person.BithDate.Year, job.StartAge, job.EndAge))
                .ToList();
        }

        public List<Person> FullSearchByJob(Job job, List<Person> personList)
        {
            return personList
                .Where(person => person.Profession == job.Profession)
                .Where(person => person.Sex == job.Sex || job.Sex == null)
                .Where(person => person.LocationPreferences.Intersect(job.Location).Any())
                .Where(person => person.JobPreferences.Intersect(job.Preferences).Any())
                .Where(person => VerifyAge(person.BithDate.Year, job.StartAge, job.EndAge))
                .ToList();
        }

        public void WriteSexCount(List<Person> personList)
        {
            var groups = personList.GroupBy(person => person.Sex);

            Console.WriteLine("Persons applied by sex: ");

            foreach (var group in groups)
            {
                Console.WriteLine($"{group.Key}: {group.Count()}");
            }
        }

        public void WriteSuitableProfessions(List<Person> personList, List<Job> jobList)
        {
            var joinedList = personList.Join(jobList,
                person => person.Profession,
                job => job.Profession,
                (person, job) => new { person.FirstName, person.LastName, job.Profession, job.Location });

            foreach (var item in joinedList)
            {
                Console.WriteLine(@$"
                {item.FirstName} {item.LastName} 
                Profession: {item.Profession}
                Location: {String.Join(", ", item.Location.ToArray())}");
            }
        }

        private bool VerifyAge(int personBirthYear, int? startAge, int? endAge)
        {
            var personAge = DateOnly.FromDateTime(DateTime.Now).Year - personBirthYear;
            bool isPersonAgeFitsStartAge =  startAge >= personAge || startAge == null;
            bool isPersonAgeFitsEndAge = personAge <= endAge || endAge == null;

            return isPersonAgeFitsStartAge && isPersonAgeFitsEndAge;
        }
    };
};