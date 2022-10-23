using Bogus;
using Homework_Module25.Classes;
using Homework_Module25.Constants;
using Homework_Module25.Enums;

namespace Homework_Module25.Helpers
{
    public class Jobs
    {
        public List<Job> GetList()
        {
            var job = new Faker<Job>()
                .RuleFor(u => u.Sex, f => f.PickRandom<Sex>().OrNull(f, .4f))
                .RuleFor(u => u.StartAge, f => f.Random.Int(IntConstants.StartAge, IntConstants.MidAge).OrNull(f, .4f))
                .RuleFor(u => u.EndAge, f => f.Random.Int(IntConstants.MidAge, IntConstants.EndAge).OrNull(f, .4f))
                .RuleFor(u => u.Profession, f => f.PickRandom(ConstantLists.Professions))
                .RuleFor(u => u.Preferences, f => f.PickRandom(ConstantLists.Preferences, f.Random.Int(1, ConstantLists.Preferences.Count)).ToList())
                .RuleFor(u => u.Location, f => f.PickRandom(ConstantLists.Locations, f.Random.Int(1, ConstantLists.Locations.Count)).ToList());

            return job.Generate(100);
        }
    }
}
