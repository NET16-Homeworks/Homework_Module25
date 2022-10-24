using Homework_Module25;

List<Job> jobs = new List<Job>()
{
    new Job()
    {
        Sex = Sex.Male,
        Location = "Minsk",
        StartAge = 18,
        EndAge = null,
        Preferances = new List<string> (){"Office"},
        Profession = "Manager"
    },
    new Job()
    {
        Sex = null,
        Location = "Minsk",
        StartAge = 18,
        EndAge = 25,
        Preferances = new List<string> (){"Office", "Home"},
        Profession = "Programmer"
    },
    new Job()
    {
        Sex = Sex.Male,
        Location = "Brest",
        StartAge = 24,
        EndAge = null,
        Preferances = new List<string> (){"Office"},
        Profession = "Butcher"
    },
    new Job()
    {
        Sex = null,
        Location = "Minsk",
        StartAge = null,
        EndAge = null,
        Preferances = new List<string> (){"Office", "Home"},
        Profession = "Advertisement manager"
    },
    new Job()
    {
        Sex = Sex.Female,
        Location = "Minsk",
        StartAge = 18,
        EndAge = null,
        Preferances = new List<string> (){"Office"},
        Profession = "Cleaner"
    },
    new Job()
    {
        Sex = Sex.Male,
        Location = "Brest",
        StartAge = 18,
        EndAge = null,
        Preferances = new List<string> (){"Office", "Free"},
        Profession = "Programmer"
    }
};
List<Person> persons = new List<Person>()
{
    new Person()
    {
        FirstName = "Ilya",
        LastName = "Maximov",
        Sex = Sex.Male,
        Email = "IlyaMaximov123@Gmail.com",
        LocationPreferances = new List<string>() { "Minsk", "Brest" },
        BirthDate = new DateTime(2000, 11, 21),
        Profession = "Programmer",
        JobPreferances = new List<string>() { "Home", "Office", "Free" },
    },
    new Person()
    {
        FirstName = "Petya",
        LastName = "Pupkin",
        Sex = Sex.Male,
        Email = "PetyaPupkin@Gmail.com",
        LocationPreferances = new List<string>() { "Brest" },
        BirthDate = new DateTime(2006, 11, 21),
        Profession = "Programmer",
        JobPreferances = new List<string>() { "Home", "Free" },
    },
    new Person()
    {
        FirstName = "German",
        LastName = "Lupkin",
        Sex = Sex.Male,
        Email = "PetyaPupkin@Gmail.com",
        LocationPreferances = new List<string>() { "Brest", "Minsk" },
        BirthDate = new DateTime(2001, 06, 03),
        Profession = "Programmer",
        JobPreferances = new List<string>() { "Home", "Free", "Office" },
    },
    new Person()
    {
        FirstName = "Anya",
        LastName = "Gubalova",
        Sex = Sex.Female,
        LocationPreferances = new List<string>() { "Minsk" },
        BirthDate = new DateTime(2003, 12, 07),
        Profession = "Advertisement manager",
        JobPreferances = new List<string>() { "Office" },
    },
    new Person()
    {
        FirstName = "Mihail",
        LastName = "Myasov",
        Sex = Sex.Male,
        LocationPreferances = new List<string>() { "Brest" },
        BirthDate = new DateTime(1992, 05, 09),
        Profession = "Butcher",
        JobPreferances = new List<string>() { "Office" },
    },

};

Searcher searcher = new Searcher();
searcher.message += message => Console.WriteLine(message);

searcher.FullSearchByPerson(persons[0], jobs);
Console.WriteLine("______________________________________________________________________________________________________");
searcher.FullSearchByJob(jobs[2], persons);
Console.WriteLine("______________________________________________________________________________________________________");
searcher.WriteSexCount(persons);
Console.WriteLine("______________________________________________________________________________________________________");
searcher.WriteSuiatableProfessions(persons, jobs);
