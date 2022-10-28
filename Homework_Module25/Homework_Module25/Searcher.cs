using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Module25
{
    internal class Searcher
    {
        public int DiffAge(DateTime BithDay)
        {
            int age = DateTime.Now.Year - BithDay.Year;
            if (BithDay.Year + age > DateTime.Now.Year)
            {
                age--;
            }
            return age; 
        }

       public List<Job> FullSearchByPerson(Person person, List<Job>? Jobs)
        {
          try
            {
                var selectedJobs =
                    from p in Jobs
                    where
                         (p.Sex is null || p.Sex == person.Sex) &&
                         (p.StartAge is null || p.StartAge <= DiffAge(person.BithDate)) &&
                         (p.EndAge is null || p.EndAge >= DiffAge(person.BithDate)) &&
                         (p.Preferences is null || (p.Preferences.Intersect(person.JobPreferences).Count() > 0)) &&
                         (p.Location is null || (p.Location.Intersect(person.LocationPreferances).Count() > 0)) &&
                         ((String.IsNullOrEmpty(person.Profession) == true) || p.Profession.ToLower() == person.Profession.ToLower())
                    select p;
               return (List<Job>)selectedJobs; 
            }
            catch(Exception e)
            {
                throw;
            }     
        }

        public List<Person> FullSearchByJob(List<Person> person, Job Jobs)
        {
            try
            {
                var selectedPerson =
                    from p in person
                    where
                        (Jobs.Sex is null || p.Sex == Jobs.Sex) &&
                        (Jobs.StartAge is null || Jobs.StartAge <= DiffAge(p.BithDate)) &&
                        (Jobs.EndAge is null || Jobs.EndAge >= DiffAge(p.BithDate)) &&
                        (Jobs.Preferences is null || (Jobs.Preferences.Intersect(p.JobPreferences).Count() > 0)) &&
                        (Jobs.Location is null || (Jobs.Location.Intersect(p.LocationPreferances).Count() > 0)) &&
                        ((String.IsNullOrEmpty(p.Profession) == true) || p.Profession.ToLower() == Jobs.Profession.ToLower())
                    select p;
                return (List<Person>)selectedPerson;
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void WriteSexCount(List<Person> person)
        {
            try
            {
                //var SexGroup = from p in person
                //               group p by p.Sex into q
                //               select new { sex = q.Key, countSex = q.Count() };

                var SexGroup = person.GroupBy(q => q.Sex).
                    Select(q => new
                    {
                        sex = q.Key,
                        sexCount = q.Count()
                    }

                    );

                foreach (var sex in SexGroup)
                {
                    if (sex.sex == Const.sex.Men)
                    {
                        Console.WriteLine($"Мужчин : {sex.sexCount}");
                    }
                    else
                    {
                        Console.WriteLine($"Женщин: {sex.sexCount}");
                    };
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public void WriteSuitableProfessions(List<Person> persons, List<Job> jobs)
        {
            try
            {
                var NewList = from p in persons
                              join q in jobs on p.Profession equals q.Profession
                              select new
                              {
                                  FirstName = p.FirstName,
                                  LastName = p.LastName,
                                  Profession = q.Profession

                              };
                foreach (var job in NewList)
                {
                    Console.WriteLine($"{job.FirstName} {job.LastName} {job.Profession}");
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
