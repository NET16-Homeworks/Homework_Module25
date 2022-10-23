using Bogus;
using Homework_Module25.Enums;
using Homework_Module25.Constants;

namespace Homework_Module25.Helpers
{
    internal class Persons
    {
        public List<Classes.Person> GetList()
        {
            var person = new Faker<Classes.Person>()
            .RuleFor(u => u.Sex, f => f.PickRandom<Sex>())
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName((Bogus.DataSets.Name.Gender)u.Sex))
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName((Bogus.DataSets.Name.Gender)u.Sex))
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.BithDate, (f, u) => DateOnly.FromDateTime(f.Date.Between(new DateTime(IntConstants.OldestYear, 1, 1), new DateTime(IntConstants.NewestYear, 12, 31))))
            .RuleFor(u => u.Profession, f => f.PickRandom(ConstantLists.Professions))
            .RuleFor(u => u.JobPreferences, f => f.PickRandom(ConstantLists.Preferences, f.Random.Int(1, ConstantLists.Preferences.Count)).ToList())
            .RuleFor(u => u.LocationPreferences, f => f.PickRandom(ConstantLists.Locations, f.Random.Int(1, ConstantLists.Locations.Count)).ToList());

           return person.Generate(100);
        }
    }


}
