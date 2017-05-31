using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Triangle : Shape
    {
        private int secondEdge;
        private int thirdEdge;

        public Triangle(int width, int height, int secondEdge, int thirdEdge) : base (width, height)
        {
            this.secondEdge = secondEdge;
            this.thirdEdge = thirdEdge;
        }
        public override int ComputeArea()
        {
            return (width * height) / 2;
        }

        public override int ComputePerimeter()
        {
            return width + secondEdge + thirdEdge;
        }
    }
}
