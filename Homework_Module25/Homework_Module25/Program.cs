using Homework_Module25;
using System.Text;

var listWithPersons = new List<Person>()
{
    new Person()
    {
        FirstName = "Vlad",
        LastName = "Pulyak",
        Email = "vlad@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateOnly(1999,10,12),
        JobPreferances = new List<string>(){"Full working day","Distant work"},
        LocationPreferances = new List<string>(){"Belarus","Poland","Lithuania","Latvia"},
        Profession = ".NET Developer"
    },
    new Person()
    {
        FirstName = "Olga",
        LastName = "Ivanova",
        Email = "olga@gmail.com",
        Sex = Sex.Woman,
        BirthDate = new DateOnly(2000,10,12),
        JobPreferances = new List<string>(){ "0.75 working day", "Distant work"},
        LocationPreferances = new List<string>(){"Lithuania","Latvia"},
        Profession = "Project Manager"
    },
    new Person()
    {
        FirstName = "Egor",
        LastName = "Semenov",
        Email = "egor@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateOnly(2000,01,11),
        JobPreferances = new List<string>(){"Full working day","Distant work"},
        LocationPreferances = new List<string>(){"Belarus","Russia"},
        Profession = "Front-end Developer"
    },
    new Person()
    {
        FirstName = "Pert",
        LastName = "Petrov",
        Email = "petr@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateOnly(2000,07,30),
        JobPreferances = new List<string>(){"0.5 working day"},
        LocationPreferances = new List<string>(){"Turkey","Poland"},
        Profession = "Fullstack Developer"
    }
};

var listWithJobs = new List<Job>()
{
    new Job()
    {
        Location = "Belarus",
        Preferances = new List<string>(){ "Distant work" },
        Sex = Sex.Man,
        StartAge = 18,
        EndAge = 35,
        Profession = "Front-end Developer"
    },
    new Job()
    {
        Location = "Poland",
        Preferances = new List<string>(){"0.5 working day"},
        Sex = Sex.Man,
        StartAge = null,
        EndAge = null,
        Profession = "Fullstack Developer"
    },
    new Job()
    {
        Location = "Lithuania",
        Preferances = new List<string>(){"0.75 working day"},
        Sex = Sex.Woman,
        StartAge = 18,
        EndAge = 35,
        Profession = "Project Manager"
    },
    new Job()
    {
        Location = "Belarus",
        Preferances = new List<string>(){"Full working day","Distant work" },
        Sex = Sex.Man,
        StartAge = 18,
        EndAge = 40,
        Profession = ".NET Developer"
    },
    new Job()
    {
        Location = "Russia",
        Preferances = new List<string>(){ "Distant work" },
        Sex = Sex.Man,
        StartAge = 19,
        EndAge = 40,
        Profession = ".NET Developer"
    }
};
IEnumerable<Job> resultSearchByPersons;
for (int i = 0; i < listWithPersons.Count; i++)
{
    resultSearchByPersons = Searcher.FullSearchByPerson(listWithPersons[i], listWithJobs);
    foreach (var item in resultSearchByPersons)
    {
        var preferances = new StringBuilder();
        foreach (var preferance in item.Preferances)
        {
            preferances.Append(preferance + "  ");
        }
        Console.WriteLine($@"Person: {listWithPersons[i].FirstName} {listWithPersons[i].LastName}" + Environment.NewLine +
                           $"Location: {item.Location}" + Environment.NewLine +
                           $"Profession: {item.Profession}" + Environment.NewLine +
                           $"Sex: {item.Sex}" + Environment.NewLine +
                           $"Age: {item.StartAge} - {item.EndAge}" + Environment.NewLine +
                           $"Preferances: {preferances}" + Environment.NewLine +
                           "========================================");
    }
}
IEnumerable<Person> resultSearchByJobs;
for (int i = 0; i < listWithJobs.Count; i++)
{
    resultSearchByJobs = Searcher.FullSearchByJob(listWithJobs[i], listWithPersons);
    foreach (var item in resultSearchByJobs)
    {
        var preferances = new StringBuilder();
        var locations = new StringBuilder();
        foreach (var preferance in item.JobPreferances)
        {
            preferances.Append(preferance + "  ");
        }
        foreach (var location in item.LocationPreferances)
        {
            locations.Append(location + "  ");
        }
        Console.WriteLine($@"Job: {listWithJobs[i].Profession}" + Environment.NewLine +
                           $"FirstName: {item.FirstName}" + Environment.NewLine +
                           $"LastName: {item.LastName}" + Environment.NewLine +
                           $"Email: {item.Email}" + Environment.NewLine +
                           $"Sex: {item.Sex}" + Environment.NewLine +
                           $"BirthDate: {item.BirthDate}" + Environment.NewLine +
                           $"Preferances: {preferances}" + Environment.NewLine +
                           $"Locations: {locations}" + Environment.NewLine +
                           $"Profession: {item.Profession}" + Environment.NewLine +
                           "========================================");
    }
}

Searcher.WriteSexCount(listWithPersons);

Searcher.WriteSuitableProfessions(listWithPersons, listWithJobs);