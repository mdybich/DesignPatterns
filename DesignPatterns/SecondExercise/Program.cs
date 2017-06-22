using SecondExercise.Decorator;
using SecondExercise.Player;
using SecondExercise.Prototype;
using SecondExercise.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecondExercise.Animals;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animals!
            Dog max = new Dog();
            Dog rex = new Pitbull();
            max.MakeNoise();
            rex.MakeNoise();


            var musicClient = new Client(new DigitalMusicFactory());
            musicClient.Play();

            var clientWithPrototype = new Client(new AnalogMusicFactoryWithPrototype());
            clientWithPrototype.Play();

            var tree = new Tree();
            tree.Draw();
            Console.WriteLine("\n\n\n");

            var treeDecorator = new TreeDecorator(tree);
            treeDecorator.Draw();

            var player = GetPlayer();
            player.Play("simple path");

        }

        public static Adapter.IPlayer GetPlayer()
        {
            return new Adapter.Adapter(new AdvancedPlayer());
        }
    }
}
