using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.OpenClosedPrinciple
{
    public class Command : ICodeElement
    {
        public void Print()
        {
            Console.WriteLine("[COMMAND]");
        }
    }
}
