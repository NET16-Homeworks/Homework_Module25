using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework_Module25
{
   public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
        public string Email { get; set; }

        public Const.sex Sex { get; set; } 

        public DateTime BithDate { get; set; }

        public List<string> JobPreferences = new List<string>();

        public List<string> LocationPreferances = new List<string>();  

        public string Profession { get; set; }
    }
}
