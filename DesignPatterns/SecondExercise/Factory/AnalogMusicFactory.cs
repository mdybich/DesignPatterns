using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Player
{
    public class AnalogMusicFactory : IMusicFactory
    {
        public Media CreateMedia()
        {
            return new Vinyl()
            {
                Name = "Some old good stuff"
            };
        }

        public IPlayer CreatePlayer()
        {
            return new GramophonePlayer();
        }
    }
}
