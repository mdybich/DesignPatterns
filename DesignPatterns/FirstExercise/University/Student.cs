using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.University
{
    public class Student : Person
    {
        public string Group { get; set; }

        public Student(string firstName, string lastName, string group) : base(firstName, lastName)
        {
            Group = group;
        }
    }
}
