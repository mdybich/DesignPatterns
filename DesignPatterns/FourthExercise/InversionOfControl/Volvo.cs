using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthExercise.InversionOfControl
{
    public class Volvo
    {
        private readonly IEngine _engine;

        public Volvo(IEngine engine)
        {
            _engine = engine;
        }
    }
}
