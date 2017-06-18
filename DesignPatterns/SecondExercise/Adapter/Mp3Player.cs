using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Adapter
{
    public class Mp3Player : IPlayer
    {
        public void Play(string path)
        {
            Console.WriteLine($"Playing mp3 from {path}");
        }
    }
}
