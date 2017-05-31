using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.University
{
    public class Assistant : Person
    {
        public string Department { get; set; }

        public Assistant(string firstName, string lastName, string department) : base(firstName, lastName)
        {
            Department = department;
        }
    }
}
