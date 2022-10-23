using Homework_Module25.Enums;

namespace Homework_Module25.Classes
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public DateOnly BithDate { get; set; }
        public string Profession { get; set; }
        public List<string> JobPreferences { get; set; } = new();
        public List<string> LocationPreferences { get; set; } = new();
    }
}