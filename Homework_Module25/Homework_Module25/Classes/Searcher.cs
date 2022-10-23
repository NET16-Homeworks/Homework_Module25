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

        void FullSearchByJob(Job job, List<Person> personList)
        {

        }

        void WriteSexCount(List<Person> personList)
        {

        }

        void WriteSuitableProfessions(List<Person> personList, List<Job> jobList)
        {

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