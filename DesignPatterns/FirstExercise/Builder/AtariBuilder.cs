using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Builder
{
    public class AtariBuilder : ComputerBuilder
    {
        public override void BuildCpu()
        {
            Computer.Cpu = "MC68000";
        }

        public override void BuildName()
        {
            Computer.Name = "Atari260ST";
        }

        public override void BuiltRam()
        {
            Computer.Ram = "512 KB RAM";
        }
    }
}
