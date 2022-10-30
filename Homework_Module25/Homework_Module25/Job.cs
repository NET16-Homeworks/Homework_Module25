using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Enums;
using Homework_Module25.Const;
using Bogus;
namespace Homework_Module25
{
    public class Job
    {
        public List<string> Location { get; set; } = new();
        public List<string> Preferences { get; set; } = new();
        public SexEnum? Sex { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public string Profession { get; set; }


        public static void PrintJobInfo(Job job)
        {
            Console.WriteLine($"Sex: {job.Sex};"+Environment.NewLine+
                    $"Start Age: {job.StartAge};" + Environment.NewLine +
                    $"End Age: {job.EndAge};" + Environment.NewLine +
                    $"Profession: {job.Profession};" + Environment.NewLine +
                    $"Preferences: {String.Join(", ", job.Preferences.ToArray())};" + Environment.NewLine +
                    $"Location: {String.Join(", ", job.Location.ToArray())}");
        }

        public List<Job> GetList()
        {
            var job = new Faker<Job>()
                .RuleFor(u => u.Sex, f => f.PickRandom<SexEnum>().OrNull(f, .4f))
                .RuleFor(u => u.StartAge, f => f.Random.Int(Other.StartAge, Other.MidAge).OrNull(f, .4f))
                .RuleFor(u => u.EndAge, f => f.Random.Int(Other.MidAge, Other.EndAge).OrNull(f, .4f))
                .RuleFor(u => u.Profession, f => f.PickRandom(Professions.professions))
                .RuleFor(u => u.Preferences, f => f.PickRandom(JobPref.JobPrefList, f.Random.Int(1, JobPref.JobPrefList.Count)).ToList())
                .RuleFor(u => u.Location, f => f.PickRandom(LocationPref.locationPref, f.Random.Int(1, LocationPref.locationPref.Count)).ToList());

            return job.Generate(50);
        }
    }
}
