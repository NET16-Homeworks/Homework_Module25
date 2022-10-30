using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Enums;
using Homework_Module25;
using Homework_Module25.Const;

namespace Homework_Module25
{
    internal class BogusHelper
    {
        public List<Person> GetList()
        {
            var person = new Faker<Person>()
            .RuleFor(u => u.Sex, f => f.PickRandom<SexEnum>())
            .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName((Bogus.DataSets.Name.Gender)u.Sex))
            .RuleFor(u => u.LastName, (f, u) => f.Name.LastName((Bogus.DataSets.Name.Gender)u.Sex))
            .RuleFor(u => u.Email, (f, u) => f.Internet.Email(u.FirstName, u.LastName))
            .RuleFor(u => u.Profession, f => f.PickRandom(Professions.professions))
            .RuleFor(u => u.JobPreferences, f => f.PickRandom(JobPref.JobPrefList, f.Random.Int(1, JobPref.JobPrefList.Count)).ToList())
            .RuleFor(u => u.LocationPreferences, f => f.PickRandom(LocationPref.locationPref, f.Random.Int(1, LocationPref.locationPref.Count)).ToList());
            //.RuleFor(u => u.BirthDate, (f, u) =>
            //{
            //    return DateOnly.FromDateTime(f.Date.Between(new DateTime(Other.OldestYear, 1, 1), new DateTime(Other.OldestYear, 12, 31)));
            //});
            return person.Generate(100);
        }
    }
}
