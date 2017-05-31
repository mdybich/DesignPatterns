using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Factory
{
    public static class ChocolateFactory
    {
        public static IChocolate MakeChocolate()
        {
            return new Chocolate();
        }
    }
}
