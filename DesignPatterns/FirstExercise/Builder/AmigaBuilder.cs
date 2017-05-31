using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Builder
{
    public class AmigaBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            Computer.Cpu = "MC68EC020";
        }

        public override void BuildName()
        {
            Computer.Name = "Amiga1200";
        }

        public override void BuiltRam()
        {
            Computer.Ram = "2 MB RAM";
        }
    }
}
