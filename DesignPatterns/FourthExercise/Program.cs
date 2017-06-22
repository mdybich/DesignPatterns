using FourthExercise.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Game advancedGame = new FirstGame();
            advancedGame.Run();

            Game simpleGame = new SecondGame();
            simpleGame.Run();
        }
    }
}
