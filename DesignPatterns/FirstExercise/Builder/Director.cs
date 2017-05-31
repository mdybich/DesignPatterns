using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise.Builder
{
    public class Director
    {
        private ComputerBuilder _computerBuilder;

        public void SetComputerBuilder(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public void ConstructComputer()
        {
            if (_computerBuilder == null)
            {
                throw new Exception("Builder is not setted!");
            }

            _computerBuilder.CreateNewComputer();
            _computerBuilder.BuildCpu();
            _computerBuilder.BuildName();
            _computerBuilder.BuiltRam();
        }

        public Computer GetComputer()
        {
            return _computerBuilder.Computer;
        }
    }
}
