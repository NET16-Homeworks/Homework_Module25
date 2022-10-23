using Homework_Module25.Enums;
using Homework_Module25.Classes;

namespace Homework_Module25.Helpers
{
    internal class PersonsSample
    {
        private List<Person> _list = new()
        {
            new Person {
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Sex = Sex.Male,
                BithDate = new DateOnly(1988, 6, 13),
                JobPreferences = new List<string> { "Программист" },
                LocationPreferences = new List<string> { "Беларусь", "Россия", "Украина" },
            },
            new Person
            {
                FirstName = "Петр",
                LastName = "Петров",
                Email = "peter@gmail.com",
                Sex = Sex.Male,
                BithDate = new DateOnly(1976, 4, 12),
                JobPreferences = new List<string> { "Девопс", "Менеджер" },
                LocationPreferences = new List<string> { "Беларусь" },
            },
            new Person
            {
                FirstName = "Сидр",
                LastName = "Сидорович",
                Email = "sider@gmail.com",
                Sex = Sex.Male,
                BithDate = new DateOnly(1990, 12, 22),
                JobPreferences = new List<string> { "Программист", "Девопс" },
                LocationPreferences = new List<string> { "Беларусь", "Украина" },
            },
            new Person
            {
                FirstName = "Анжела",
                LastName = "Булкина",
                Email = "angy-bumms@gmail.com",
                Sex = Sex.Female,
                BithDate = new DateOnly(1993, 3, 19),
                JobPreferences = new List<string> { "Менеджер" },
                LocationPreferences = new List<string> { "Беларусь", "Россия" },
            },
            new Person
            {
                FirstName = "Дуня",
                LastName = "Кулакова",
                Email = "doonysha@gmail.com",
                Sex = Sex.Female,
                BithDate = new DateOnly(1980, 1, 30),
                JobPreferences = new List<string> { "Менеджер", "Девопс" },
                LocationPreferences = new List<string> { "Беларусь", "Украина" },
            },
            new Person
            {
                FirstName = "Галя",
                LastName = "Якина",
                Email = "galyusha@gmail.com",
                Sex = Sex.Female,
                BithDate = new DateOnly(1971, 2, 22),
                JobPreferences = new List<string> { "Менеджер", "Программист" },
                LocationPreferences = new List<string> { "Россия", "Украина" },
            },
        };
        public List<Person> GetList()
        {
            return _list;
        }
    }
}
