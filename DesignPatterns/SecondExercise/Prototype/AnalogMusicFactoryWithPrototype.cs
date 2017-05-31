using SecondExercise.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Prototype
{
    public class AnalogMusicFactoryWithPrototype : IMusicFactory
    {
        public VinylPrototype VinylPrototype { get; set; }
        public GramophonePlayerPrototype GramophonePlayerPrototype { get; set; }

        public AnalogMusicFactoryWithPrototype()
        {
            VinylPrototype = new VinylPrototype()
            {
                Name = "Vinyl"
            };

            GramophonePlayerPrototype = new GramophonePlayerPrototype() { };
        }

        public Media CreateMedia()
        {
            return VinylPrototype.Clone() as Media;
        }

        public IPlayer CreatePlayer()
        {
            return GramophonePlayerPrototype.Clone() as IPlayer;
        }
    }
}
