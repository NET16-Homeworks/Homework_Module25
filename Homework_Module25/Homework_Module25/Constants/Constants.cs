namespace Homework_Module25.Constants
{
    public static class ConstantLists
    {
        public static List<string> Professions { get; } = new() { "Менеджер", "Программист", "Девопс" };
        public static List<string> Locations { get; } = new() { "Беларусь", "Россия", "Украина" };
        public static List<string> Preferences { get; } = new() { "частичная занятость", "полная занятость", "удаленная работа" };
    }

    public static class IntConstants
    {
        public const int OldestYear = 1970;
        public const int NewestYear = 2000;
        public const int StartAge = 18;
        public const int MidAge = 30;
        public const int EndAge = 45;
    }
}
