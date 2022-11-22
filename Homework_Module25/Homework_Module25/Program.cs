using Homework_Module25;

List<Person> listOfPersons = new List<Person>()
{
    new Person()
    {
        FirstName = "Павел",
        LastName = "Леванок",
        Email = "pavel.levanok@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateTime(1985, 09, 16),
        JobPreferences = new List<string>() {"Удаленная работа", "Полный рабочий день"},
        LocationPreferences = new List<string>() {"Беларусь", "Польша", "Украина" },
        Profession = ".Net разработчик"
    },
    new Person()
    {
        FirstName = "Ольга",
        LastName = "Иванова",
        Email = "ivanova@gmail.com",
        Sex = Sex.Women,
        BirthDate = new DateTime(1995, 10, 16),
        JobPreferences = new List<string>() {"Удаленная работа", "Не полный рабочий день"},
        LocationPreferences = new List<string>() {"Беларусь", "Польша", "Литва" },
        Profession = ".Net разработчик"
    },
    new Person()
    {
        FirstName = "Александр",
        LastName = "Демидов",
        Email = "demidov@gmail.com",
        Sex = Sex.Man,
        BirthDate = new DateTime(1975, 10, 16),
        JobPreferences = new List<string>() {"Удаленная работа", "Полный рабочий день"},
        LocationPreferences = new List<string>() {"Беларусь", "Польша"},
        Profession = "Java разработчик"
    },
    new Person()
    {
        FirstName = "Александра",
        LastName = "Демидова",
        Email = "demidovа@gmail.com",
        Sex = Sex.Women,
        BirthDate = new DateTime(1980, 10, 16),
        JobPreferences = new List<string>() {"Удаленная работа", "Полный рабочий день"},
        LocationPreferences = new List<string>() {"Беларусь", "Польша", "Украина"},
        Profession = "Java разработчик"
    },
    new Person()
    {
        FirstName = "Александра",
        LastName = "Круглова",
        Email = "krug@gmail.com",
        Sex = Sex.Women,
        BirthDate = new DateTime(1990, 10, 28),
        JobPreferences = new List<string>() {"Полный рабочий день"},
        LocationPreferences = new List<string>() {"Беларусь"},
        Profession = "Директор"
    },
};

List<Job> listOfJobs = new List<Job>()
{
    new Job()
    {
        Location = "Беларусь",
        Preferences = new List<string>() { "Полный рабочий день"},
        Sex = null,
        StartAge = 18,
        EndAge = 55,
        Profession = ".Net разработчик"
    },
    new Job()
    {
        Location = "Польша",
        Preferences = new List<string>() { "Удаленная работа", "Полный рабочий день"},
        Sex = Sex.Women,
        StartAge = 18,
        EndAge = 55,
        Profession = ".Net разработчик",
    },
    new Job()
    {
        Location = "Украина",
        Preferences = new List<string>() { "Удаленная работа" },
        Sex = Sex.Man,
        StartAge = 18,
        EndAge = 55,
        Profession = "Java разработчик",
    },
    new Job()
    {
        Location = "Беларусь",
        Preferences = new List<string>() { "Полный рабочий день" },
        Sex = null,
        StartAge = 18,
        EndAge = 55,
        Profession = "Директор",
    },
};

var resultSearchJob = Seacher.FullSearchByPerson(listOfPersons[0], listOfJobs);

foreach (var job in resultSearchJob)
{
    Console.WriteLine($"Данному человеку подходит вакансия '{job.Profession}', в стране: '{job.Location}' ");
}

var resultSearchPerson = Seacher.FullSearchByJob(listOfJobs[0], listOfPersons);

foreach (var person in resultSearchPerson)
{
    Console.WriteLine($"На эту вакансию подходит {person.FirstName} {person.LastName}");
}


Seacher.WriteSexCount(listOfPersons);

Seacher.WriteSuitableProfessions(listOfPersons, listOfJobs);






