using Homework_Module25.Enums;

namespace Homework_Module25.Classes
{
    internal class Job
    {
        public Sex? Sex { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public string Profession { get; set; }
        public List<string> Location { get; set; } = new();
        public List<string> Preferences { get; set; } = new();
    }
}