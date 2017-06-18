using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Adapter
{
    public class AdvancedPlayer
    {
        public void PlayMp4(string path)
        {
            Console.WriteLine($"Playing mp4 from {path}");
        }

        public void PlayVlc(string path)
        {
            Console.WriteLine($"Playing VLC from {path}");
        }
    }
}
