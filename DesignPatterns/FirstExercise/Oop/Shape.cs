using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public abstract class Shape
    {
        protected int height;
        protected int width;

        public Shape(int width = 0, int height = 0)
        {
            this.height = height;
            this.width = width;
        }

        public abstract int ComputeArea();
        public abstract int ComputePerimeter();
    }
}
