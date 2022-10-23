using Homework_Module25;
using Homework_Module25.Enums;

List<Person> people = new List<Person>()
{
    new Person()
    {
        FirstName = "Helen",
        LastName = "Solodukhina",
        Email = "elena-solodukhina@mail.ru",
        Sex = Sex.Woman,
        BirthDate = new DateTime(1995,7,15),
        JobPreferences = new List<string> {"Full-time", "Remote work", "Part-time"},
        LocationPreferences = new List<string> {"Belarus", "Poland"},
        Profession = "Project Manager"
    },

    new Person()
    {
        FirstName = "Maksim",
        LastName = "Piatrou",
        Email = "maks-piatrou@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateTime(1983,2,1),
        JobPreferences = new List<string> {"Full-time", "At place"},
        //если ставить налл след значение, вылазит ошибка.  пофиксить
        LocationPreferences = null,
        //LocationPreferences = new List<string> {"Belarus", "USA"},
        Profession = "Financial Director"
    },

    new Person()
    {
        FirstName = "Mikhail",
        LastName = "Mirniy",
        Email = "misha-mirniy@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateTime(1998,5,4),
        JobPreferences = new List<string> {"Flexible", "At place", "Remote", "Part-time", "Full-time"},
        LocationPreferences  = new List<string> {"Belarus", "Georgia", "Russia"},
        Profession = "Junior Java-developer"
    },

     new Person()
    {
        FirstName = "Arty",
        LastName = "Zubovich",
        Email = "arty-zubovich@mail.ru",
        Sex = Sex.Man,
        BirthDate = new DateTime(1993,6,4),
        JobPreferences = new List<string> {"Office", "Remote work", "Part-time"},
        LocationPreferences = new List<string> {"Belarus"},
        Profession = "Builder"
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
        Profession = "Financial Director"
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
        Location = "Georgia",
        StartAge = 18,
        EndAge = 60,
        Preferences = new List<string> () {"At place"},
        Profession = "Junior Java-developer"
    },
    new Job()
    {
        Sex = null,
        Location = "Germany",
        StartAge = 18,
        EndAge = null,
        Preferences = new List<string> () {"Remote work"},
        Profession = "IT support"
    },
    new Job()
    {
        Sex = Sex.Man,
        Location = "Belarus",
        StartAge = 18,
        EndAge = 55,
        Preferences = new List<string> () {"Full-time"},
        Profession = "Builder"
    },

    new Job()
    {
        Sex = null,
        Location = "Poland",
        StartAge = 20,
        EndAge = 60,
        Preferences = new List<string> (){"At place", "Full-time"},
        Profession = "Science Teacher"
    }
};

Searcher searcher = new Searcher();

Console.WriteLine("Job applicable per your request");
searcher.FullSearchByPerson(people[1], jobs);

Console.WriteLine("#############################");
Console.WriteLine("People falling under the list of stated requirements:");
searcher.FullSearchByJob(jobs[0], people);

Console.WriteLine("#############################");
Console.WriteLine("Sex and count of people");
searcher.WriteSexCount(people);

Console.WriteLine("#############################");
Console.WriteLine("People and appropriate jobs for them:");
searcher.WriteSuitableProfessions(people, jobs);


