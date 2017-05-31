using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Builder
{
    public abstract class ComputerBuilder
    {
        public Computer Computer { get; set; }
        public void CreateNewComputer()
        {
            Computer = new Computer();
        }

        public abstract void BuildName();
        public abstract void BuildCpu();
        public abstract void BuiltRam();
    }
}
