using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    internal class Job
    {
        public string Location { get; set; }
        public List<string> Preferences { get; set; }
        public GenderEnum? Gender { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        public string Profession { get; set; }

        public void PrintJob(Job job)
        {
            string? gender = job.Gender == null ? "не важен" : job.Gender.ToString();
            string? preference = "";

            foreach (string item in job.Preferences)
                preference = preference + item + " ";

            Console.WriteLine($"Профессия: {job.Profession}\nСтрана: {job.Location}\nПол: {gender}\nПредпочтения: {preference}\nВозраст: {job.StartAge} - {job.EndAge}");
            Console.WriteLine();
        }
    }
}
