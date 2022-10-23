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
                .Where(job => job.Sex == null || job.Sex == person.Sex)
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

        private bool VerifyAge(int personAge, int? startAge, int? endAge)
        {
            bool isPersonAgeFitsStartAge = startAge == null || startAge >= personAge;
            bool isPersonAgeFitsEndAge = endAge == null || personAge <= endAge;

            return isPersonAgeFitsStartAge && isPersonAgeFitsEndAge;
        }
    };
};