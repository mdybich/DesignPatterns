using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height) : base(width, height)
        {}

        public override int ComputeArea()
        {
            return width * height;
        }

        public override int ComputePerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
