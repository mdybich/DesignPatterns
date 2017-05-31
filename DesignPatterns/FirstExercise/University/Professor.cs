using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.University
{
    public class Professor : Person
    {
        public int Experience { get; set; }
        public Professor(string firstName, string lastName, int experience) : base(firstName, lastName)
        {
            Experience = experience;
        }
    }
}
