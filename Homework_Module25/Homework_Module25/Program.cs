using Homework_Module25.Enums;
using Homework_Module25.Classes;
using Homework_Module25.Helpers;

List<Person> persons = new PersonsSample().GetList();
List<Job> jobs = new JobsSample().GetList();
var searcher = new Searcher();

var result = searcher.FullSearchByPerson(persons[5], jobs);

foreach (var item in result)
{
    Console.WriteLine(item);
}