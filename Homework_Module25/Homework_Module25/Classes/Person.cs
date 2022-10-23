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
        public static void GetDetails(Person person)
        {
            Console.WriteLine($@"
                    Name: {person.FirstName} {person.LastName};
                    Email: {person.Email};
                    Sex: {person.Sex};
                    Birth Date: {person.BithDate};
                    Profession: {person.Profession};
                    JobPreferences: {String.Join(", ", person.JobPreferences.ToArray())};
                    LocationPreferences: {String.Join(", ", person.LocationPreferences.ToArray())};
                ");
        }
    };
};