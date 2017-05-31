using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.University
{
    public class University
    {
        public List<Person> Persons { get; set; }
        public List<Student> Students { get; set; }
        public List<Assistant> Assistants { get; set; }
        public List<Professor> Professors { get; set; }

        public University()
        {
            Persons = new List<Person>();
            Students = new List<Student>();
            Assistants = new List<Assistant>();
            Professors = new List<Professor>();

            Persons.Add(new Student("John", "Doe", "IJO"));
            Persons.Add(new Student("Mike", "Kazinsky", "IJO"));

            Persons.Add(new Assistant("Natalie", "Portman", "WIINOM"));
            Persons.Add(new Assistant("John", "Porter", "WIINOM"));

            Persons.Add(new Professor("Michael", "Pitt", 12));
            Persons.Add(new Professor("Ryan", "Goodman", 12));
        }
    }
}
