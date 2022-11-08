using Homework_Module25;
using Homework_Module25.Enums;

List<Person> people = new List<Person>()
{
    new Person()
    {
        FirstName = "Dmitriy",
        LastName = "Danenkov",
        Email = "Danenkov.dmitriy@mail.ru",
        Sex = Sex.Man,
        BirthDate = new DateTime(1999,3,9),
        JobPreferences = new List<string> {"Full-time", "Remote work", "Part-time"},
        LocationPreferences = new List<string> {"Belarus", "Poland"},
        Profession = "Engineer"
    },

    new Person()
    {
        FirstName = "Dariya",
        LastName = "Lomeiko",
        Email = "Lomeiko@gmail.com",
        Sex = Sex.Woman,
        BirthDate = new DateTime(1999,2,12),
        JobPreferences = new List<string> {"Full-time", "At place"},
        LocationPreferences = null,
        Profession = "Bank Director"
    },

    new Person()
    {
        FirstName = "Maxim",
        LastName = "Penek",
        Email = "Max-pain@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateTime(1996,5,3),
        JobPreferences = new List<string> {"Flexible", "At place", "Remote", "Part-time", "Full-time"},
        LocationPreferences  = new List<string> {"Belarus", "Yamaika", "Russia"},
        Profession = "Senior C# developer"
    },

     new Person()
    {
        FirstName = "Danna",
        LastName = "Mall",
        Email = "Mall@mail.ru",
        Sex = Sex.Man,
        BirthDate = new DateTime(2003,6,4),
        JobPreferences = new List<string> {"Office", "Remote work", "Part-time"},
        LocationPreferences = new List<string> {"Belarus"},
        Profession = "Shopping Man"
    },
};

List<Job> jobs = new List<Job>()
{
    new Job()
    {
        Sex = null,
        Location = "Belarus",
        StartAge = 25,
        EndAge = 50,
        Preferences = new List<string> () {"At place", "Full-time"},
        Profession = "Bank Director"
    },

    new Job()
    {
        Sex = Sex.Woman,
        Location = "Poland",
        StartAge = 18,
        EndAge = 29,
        Preferences = new List<string> () {"At Place", "Part-time"},
        Profession = "Project Manager"
    },

    new Job()
    {
        Sex = null,
        Location = "Yamaika",
        StartAge = 18,
        EndAge = 60,
        Preferences = new List<string> () {"At place"},
        Profession = "Junior C++ Developer"
    },
    new Job()
    {
        Sex = null,
        Location = "Germany",
        StartAge = 18,
        EndAge = null,
        Preferences = new List<string> () {"Remote work"},
        Profession = "IT Manager"
    },
    new Job()
    {
        Sex = Sex.Man,
        Location = "Belarus",
        StartAge = 18,
        EndAge = 57,
        Preferences = new List<string> () {"Full-time"},
        Profession = "Twitch streamer"
    },

    new Job()
    {
        Sex = null,
        Location = "Poland",
        StartAge = 20,
        EndAge = 60,
        Preferences = new List<string> (){"At place", "Full-time"},
        Profession = "Auto Engineer"
    }
};

Searcher searcher = new Searcher();

Console.WriteLine("Job Accepted by your request");
searcher.FullSearchByPerson(people[1], jobs);

Console.WriteLine("People falling under the list of stated requirements:");
searcher.FullSearchByJob(jobs[1], people);

Console.WriteLine("Sex+count of people");
searcher.WriteSexCount(people);

Console.WriteLine("People and Priority jobs for them:");
searcher.WriteSuitableProfessions(people, jobs);


