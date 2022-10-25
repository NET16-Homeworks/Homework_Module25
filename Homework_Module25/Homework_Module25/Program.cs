using Homework_Module25.Enums;
using Homework_Module25.Classes;
using Homework_Module25.Helpers;
using Homework_Module25.Extentions;

List<Person> persons = new Persons().GetList();
List<Job> jobs = new Jobs().GetList();

var searcher = new Searcher();
var person = persons[0];
var job = jobs[0];

//Person.GetDetails(person);
//var jobSearchResult = searcher.FullSearchByPerson(person, jobs);
//jobSearchResult.GetJobDetails();

//Job.GetDetails(job);
//var personSearchResult = searcher.FullSearchByJob(job, persons);
//personSearchResult.GetPersonsDetails();

//searcher.WriteSexCount(persons);

searcher.WriteSuitableProfessions(persons, jobs);