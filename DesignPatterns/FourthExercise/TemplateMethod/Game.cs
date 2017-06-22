using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.TemplateMethod
{
    public abstract class Game
    {
        public string WinnerName { get; protected set; }
        protected virtual void SetGame()
        {
            Console.WriteLine("Setting game...");
        }

        protected abstract void Play();
        protected abstract void FinishGame();

        protected virtual void ShowWinner()
        {
            Console.WriteLine($"And the winner is... {WinnerName}");
        }

        public void Run()
        {
            this.SetGame();
            this.Play();
            this.FinishGame();
            this.ShowWinner();
        }
    }
}
