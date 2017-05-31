using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.University
{
    public class Base
    {
        public University University { get; set; }

        public Base()
        {
            University = new University();
        }

        public void ShowData()
        {
            Console.WriteLine("UNIVERSITY\n\n");
            Console.WriteLine("Students:");

            foreach (var student in University.Students)
            {
                Console.WriteLine($"* {student.FirstName} {student.LastName} - {student.Group}");
            }

            Console.WriteLine("Assistants:");

            foreach (var assistant in University.Assistants)
            {
                Console.WriteLine($"* {assistant.FirstName} {assistant.LastName} - {assistant.Department}");
            }

            Console.WriteLine("Professors:");

            foreach (var professor in University.Professors)
            {
                Console.WriteLine($"* {professor.FirstName} {professor.LastName} - {professor.Experience}");
            }
        }
    }
}
