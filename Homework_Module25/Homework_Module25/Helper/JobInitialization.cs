using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25.Helper
{
    public static class JobInitialization
    {
        public static Job InitializeNewJob()
        {
            var job = new Job()
            {
                Location = "Belarus",
                Preferences = "Full time",
                StartAge = 18,
                EndAge = 30,
                Sex = SexEnum.Woman,
                Profession = "Doctor"
            };

            return job;
        }

        public static List<Job> InitializeJobsList()
        {
            List<Job> jobs = new List<Job>()
            {
                new Job()
                {
                    Location = "Belarus",
                    Preferences = "Full time",
                    StartAge = 18,
                    EndAge = 30,
                    Sex = SexEnum.Woman,
                    Profession = "Manager"
                },
                new Job()
                {
                    Location = "Belarus",
                    Preferences = "Full time",
                    StartAge = 25,
                    EndAge = 45,
                    Sex = SexEnum.Man,
                    Profession = "Process Engineer"
                },
                new Job()
                {
                    Location = "Ukraine",
                    Preferences = "Full time",
                    StartAge = 25,
                    EndAge = 35,
                    Profession = "Administrator"
                },
                new Job()
                {
                    Location = "Poland",
                    Preferences = "Part time",
                    StartAge = 18,
                    EndAge = 35,
                    Profession = "Programmer (.Net developer)"
                },
                new Job()
                {
                    Location = "Georgia",
                    Preferences = "Part time",
                    Profession = "Programmer (React developer)"
                },
                new Job()
                {
                    Location = "Belarus",
                    Preferences = "Part time",
                    StartAge = 18,
                    EndAge = 29,
                    Sex = SexEnum.Man,
                    Profession = "Delivery driver"
                },
                new Job()
                {
                    Location = "Poland",
                    Preferences = "Full time",
                    StartAge = 18,
                    Profession = "Doctor"
                },
            };

            return jobs;
        } 
    }
}
