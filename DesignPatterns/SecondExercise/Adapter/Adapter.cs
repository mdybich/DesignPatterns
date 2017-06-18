using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Adapter
{
    public class Adapter : IPlayer
    {
        private AdvancedPlayer _advancedPlayer;

        public Adapter(AdvancedPlayer advancedPlayer)
        {
            _advancedPlayer = advancedPlayer;
        }

        public void Play(string path)
        {
            _advancedPlayer.PlayMp4(path);
        }
    }
}
