using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Player
{
    public class Client
    {
        private IMusicFactory _musicFactory;
        public Client(IMusicFactory musicFactory)
        {
            _musicFactory = musicFactory;
        }

        public void Play()
        {
            var player = _musicFactory.CreatePlayer();
            player.Play(_musicFactory.CreateMedia());
        }
    }
}
