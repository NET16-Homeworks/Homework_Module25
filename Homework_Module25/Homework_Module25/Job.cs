using Homework_Module25.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module25
{
    public sealed class Job
    {
        public string Location { get; set; }
        public HashSet<string> Preferences { get; set; } = new HashSet<string>();
        public Sex? Sex { get; set; }
        public int? StartAge { get; set; }
        public int? EndAge { get; set; }
        public string Profession { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine($"Location: {Location}");
            result.AppendLine($"Profession: {Profession}");

            if (Sex != null)
                result.AppendLine($"Sex: {Sex}");
            else
                result.AppendLine($"Sex: N/A");

            if (StartAge != null)
                result.AppendLine($"StartAge: {StartAge}");
            else
                result.AppendLine("StartAge: N/A");

            if (EndAge != null)
                result.AppendLine($"EndAge: {EndAge}");
            else
                result.AppendLine("EndAge: N/A");

            result.Append("Preferences: ");
            foreach (var preference in Preferences)
            {
                result.Append($"{preference}, ");
            }
            result.AppendLine();

            return result.ToString();
        }
    }
}
