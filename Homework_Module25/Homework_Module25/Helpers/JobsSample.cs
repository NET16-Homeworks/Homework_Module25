using Homework_Module25.Enums;
using Homework_Module25.Classes;

namespace Homework_Module25.Helpers
{
    internal class JobsSample
    {
        private List<Job> _list = new()
        {
            new Job()
            {
                Sex = Sex.Female,
                StartAge = 18,
                EndAge = 24,
                Profession = "Менеджер",
                Location = new List<string> { "Беларусь", "Украина" },
                Preferences = new List<string> { "частичная занятость", "полная занятость" }
                
            },
            new Job()
            {
                Sex = Sex.Male,
                StartAge = 21,
                EndAge = 30,
                Profession = "Девопс",
                Location = new List<string> { "Украина" },
                Preferences = new List<string> { "частичная занятость", "полная занятость", "удаленная работа" }
            },
            new Job()
            {
                Profession = "Программист",
                Location = new List<string> { "Беларусь", "Украина", "Россия" },
                Preferences = new List<string> { "частичная занятость", "полная занятость", "удаленная работа" }
            },
        };

        public List<Job> GetList()
        {
            return _list;
        }
    }
}
