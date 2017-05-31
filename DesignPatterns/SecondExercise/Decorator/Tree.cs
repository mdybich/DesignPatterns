using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Decorator
{
    public class Tree : ITree
    {
        public void Draw()
        {
            for (var i = 0; i < 20; i++)
            {
                DrawRow(i);
            }
        }

        public void DrawRow(int rowNumber)
        {
            for (var i = 0; i <= rowNumber; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
