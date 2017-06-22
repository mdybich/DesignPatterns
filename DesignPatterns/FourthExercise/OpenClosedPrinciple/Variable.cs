using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.OpenClosedPrinciple
{
    public class Variable : ICodeElement
    {
        public void Print()
        {
            Console.WriteLine("[VARIABLE");
        }
    }
}
