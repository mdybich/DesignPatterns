using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Decorator
{
    public class TreeDecorator : ITreeDecorator
    {
        public TreeDecorator(ITree tree) : base(tree)
        {
        }

        public override void Draw()
        {
            for (var i = 0; i < 40; i++)
            {
                DrawRow(i);
            }
        }

        public override void DrawRow(int rowNumber)
        {
            if (rowNumber % 2 == 0)
            {
                base.DrawRow(rowNumber);
            } else
            {
                for (var i = 0; i <= rowNumber; i++)
                {
                    Console.Write("@");
                }
                Console.WriteLine();
            }
        }
    }
}
