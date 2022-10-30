
using Homework_Module25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_Module25.Const;
using Homework_Module25.Enums;

        List<Person> persons = new BogusHelper().GetList();
        List<Job> jobs = new Job().GetList();

        var searcher = new Searcher();
        var person = persons[0];
        var job = jobs[0];

        Person.PrintPersonInfo(person);
        var jobSearchResult = searcher.FullSearchByPerson(person, jobs);
        jobSearchResult.GetJobDetails();

        Job.PrintJobInfo(job);
            var personSearchResult = searcher.FullSearchByJob(job, persons);
        personSearchResult.GetPersonInfo();

            searcher.WriteSexApplied(persons);

            searcher.WriteSuitableProfessions(persons, jobs);
    
