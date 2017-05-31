using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Player
{
    public class DigitalMusicFactory : IMusicFactory
    {
        public Media CreateMedia()
        {
            return new Cd()
            {
                Name = "Digital media"
            };
        }

        public IPlayer CreatePlayer()
        {
            return new CdPlayer();
        }
    }
}
