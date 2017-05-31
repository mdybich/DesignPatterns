using SecondExercise.Decorator;
using SecondExercise.Player;
using SecondExercise.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var musicClient = new Client(new DigitalMusicFactory());
            musicClient.Play();

            var clientWithPrototype = new Client(new AnalogMusicFactoryWithPrototype());
            clientWithPrototype.Play();

            var tree = new Tree();
            tree.Draw();
            Console.WriteLine("\n\n\n");

            var treeDecorator = new TreeDecorator(tree);
            treeDecorator.Draw();
        }
    }
}
