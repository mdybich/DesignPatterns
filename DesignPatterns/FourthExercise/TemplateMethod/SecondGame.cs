using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.TemplateMethod
{
    public class SecondGame : Game
    {
        protected override void FinishGame()
        {
            WinnerName = "George";
        }

        protected override void Play()
        {
            Console.WriteLine($"Playing very simple game where George is always winner!");
        }
    }
}
