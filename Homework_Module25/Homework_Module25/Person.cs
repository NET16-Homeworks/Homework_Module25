using Homework_Module25.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public sealed class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public HashSet<string> JobPreferences { get; set; } = new HashSet<string>();
        public HashSet<string>? LocationPreferances { get; set; } = new HashSet<string>();
        public string Profession { get; set; }

        public int GetYears()
        {
            DateTime date = DateTime.UtcNow;
            int age = ((date.Year * 12 + date.Month) - (BirthDate.Year * 12 + BirthDate.Month)) / 12;
            return age;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"FirstName: {FirstName}");
            result.AppendLine($"LastName: {LastName}");
            result.AppendLine($"Email: {Email}");
            result.AppendLine($"Sex: {Sex}");
            result.AppendLine($"BirthDate: {BirthDate}");
            result.AppendLine($"Profession: {Profession}");

            result.Append("JobPreferences: ");
            foreach (var jobPreferences in JobPreferences)
            {
                result.Append($"{jobPreferences}, ");
            }
            result.AppendLine();

            result.Append("LocationPreferances: ");
            foreach (var locationPreferances in LocationPreferances)
            {
                result.Append($"{locationPreferances}, ");
            }
            result.AppendLine();

            return result.ToString();
        }
    }
}
