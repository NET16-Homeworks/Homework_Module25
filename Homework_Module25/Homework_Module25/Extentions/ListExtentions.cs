using Homework_Module25.Enums;
using Homework_Module25.Classes;

namespace Homework_Module25.Extentions
{
    public static class ListExtentions
    {
        public static void GetPersonsDetails(this List<Person> persons)
        {
            foreach (var person in persons)
            {
                Person.GetDetails(person);
            }
        }

        public static void GetJobDetails(this List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                Job.GetDetails(job);
            }
        }
    }
}
