using Homework_Module25;
using Homework_Module25.Helper;

List<Person> people = PersonInitialization.InitializePeopleList();
var person = PersonInitialization.InitializeNewPerson();
var jobs = JobInitialization.InitializeJobsList();
var job = JobInitialization.InitializeNewJob();

var searchedJobs = Searcher.FullSearchByPerson(person, jobs);
var searchedPeople = Searcher.FullSearchByJob(people, job);

Console.WriteLine("\n-----------------WriteSexCount-----------------");
Searcher.WriteSexCount(people);

Console.WriteLine("\n-----------------WriteSuitableProfession-----------------");
Searcher.WriteSuitableProfession(people, jobs);

Console.WriteLine("\n-----------------FullSearchByPerson-----------------");
foreach (var searchedJob in searchedJobs)
{
    Console.WriteLine($"{searchedJob.Preferences}, {searchedJob.Profession}, {searchedJob.Location}");
}

Console.WriteLine("\n-----------------FullSearchByJob-----------------");
foreach (var searchedPerson in searchedPeople)
{
    Console.WriteLine($"{searchedPerson.FirstName} {searchedPerson.LastName} - {searchedPerson.Profession}");
}