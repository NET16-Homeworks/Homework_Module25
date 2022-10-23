using Homework_Module25;
using System.Linq.Expressions;

//jobPreferences = new List<string> { "Полный день", "Сменный график", "Гибкий график", "Удаленная работа", "Вахтовый метод" };

var personList = new List<Person>
{
    new Person
    {
        FirstName = "Ivan",
        LastName = "Ivanov",
        Email = "qwer@mail.ru",
        Gender = GenderEnum.Male,
        BirthDate = new DateTime (2000, 1, 2),
        JobPreferences = new List<string> {"Полный день", "Сменный график"},
        LocationPreferances = new List<string> {"Беларусь", "Россия" },
        Profession = "Manager"
    },
    new Person
    {
        FirstName = "Svetlana",
        LastName = "Ivanova",
        Email = "qwert@mail.ru",
        Gender = GenderEnum.Female,
        BirthDate = new DateTime (1998, 1, 2),
        JobPreferences = new List<string> {"Удаленная работа", "Гибкий график"},
        LocationPreferances = new List<string> {"Германия", "Польша", "США" },
        Profession = "Full-stack developer"
    },
    new Person
    {
        FirstName = "Petr",
        LastName = "Petrov",
        Email = "qwerty@mail.ru",
        Gender = GenderEnum.Male,
        BirthDate = new DateTime (1992, 1, 2),
        JobPreferences = new List<string> {"Вахтовый метод"},
        LocationPreferances = new List<string> {"США", "Россия"},
        Profession = "Engineer"
    },
    new Person
    {
        FirstName = "Sergey",
        LastName = "Serov",
        Email = "qwertyi@mail.ru",
        Gender = GenderEnum.Male,
        BirthDate = new DateTime (1992, 1, 2),
        JobPreferences = new List<string> {"Вахтовый метод"},
        LocationPreferances = new List<string> {"США", "Россия"},
        Profession = "Engineer"
    },
};

var jobList = new List<Job>
{
    new Job
    {
        Location = "США",
        Preferences = new List<string> {"Удаленная работа", "Гибкий график" },
        Gender = null,
        StartAge = 0,
        EndAge = 24,
        Profession = "Full-stack developer"
    },
    new Job
    {
        Location = "Россия",
        Preferences = new List<string> {"Полный день", "Вахтовый метод" },
        Gender = GenderEnum.Male,
        StartAge = 25,
        EndAge = 0,
        Profession = "Engineer"
    },
    new Job
    {
        Location = "США",
        Preferences = new List<string> {"Полный день", "Вахтовый метод" },
        Gender = GenderEnum.Male,
        StartAge = 25,
        EndAge = 50,
        Profession = "Engineer"
    }
};

Searcher searcher = new Searcher();

Console.WriteLine("Профессии по человеку");
searcher.FullSearchByPerson(personList[2], jobList);

Console.WriteLine("Люди по профессии");
searcher.FullSearchByJob(jobList[1], personList);

Console.WriteLine("Счетчик гендеров");
searcher.WriteGenderCount(personList);

Console.WriteLine("Подходящие профессии");
searcher.WriteSuitableProfessions(personList, jobList);
