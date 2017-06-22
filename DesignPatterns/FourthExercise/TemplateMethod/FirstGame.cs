using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.TemplateMethod
{
    public class FirstGame : Game
    {
        public List<Gamer> Gamers { get; private set; }

        protected override void SetGame()
        {
            Gamers = new List<Gamer>();
            Gamers.Add(new Gamer
            {
                Name = "Michael"
            });
            Gamers.Add(new Gamer
            {
                Name = "John"
            });
        }

        protected override void Play()
        {
            var rnd = new Random();
            Gamers.ForEach(g => g.Result = rnd.Next());
        }

        protected override void FinishGame()
        {
            WinnerName = Gamers.OrderByDescending(g => g.Result).First().Name;
        }
    }
}
