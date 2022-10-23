using Homework_Module25.Enums;

namespace Homework_Module25.Classes
{
    public class Job
    {
        public Sex? Sex { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public string Profession { get; set; }
        public List<string> Location { get; set; } = new();
        public List<string> Preferences { get; set; } = new();
        public static void GetDetails(Job job)
        {
            Console.WriteLine($@"
                    Sex: {job.Sex};
                    Start Age: {job.StartAge};
                    End Age: {job.EndAge};
                    Profession: {job.Profession};
                    Preferences: {String.Join(", ", job.Preferences.ToArray())};
                    Location: {String.Join(", ", job.Location.ToArray())};
                ");
        }
    };
};