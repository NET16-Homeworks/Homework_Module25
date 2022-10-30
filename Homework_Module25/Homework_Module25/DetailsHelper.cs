using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public static class DetailsHelper
    {
        public static void GetPersonInfo(this List<Person> persons)
        {
            foreach (var person in persons)
            {
                Person.PrintPersonInfo(person);
            }
        }

        public static void GetJobDetails(this List<Job> jobs)
        {
            foreach (var job in jobs)
            {
                Job.PrintJobInfo(job);
            }
        }
    }
}
