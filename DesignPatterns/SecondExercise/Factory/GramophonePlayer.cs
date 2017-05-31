using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Player
{
    public class GramophonePlayer : IPlayer
    {
        public void Play(Media media)
        {
            Console.WriteLine($"Im playing {media.Name} on GramophonePlayer");
        }
    }
}
