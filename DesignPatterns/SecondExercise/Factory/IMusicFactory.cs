using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Player
{
    public interface IMusicFactory
    {
        IPlayer CreatePlayer();
        Media CreateMedia();
    }
}
