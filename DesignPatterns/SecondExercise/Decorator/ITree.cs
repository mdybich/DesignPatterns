using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Decorator
{
    public interface ITree
    {
        void Draw();
        void DrawRow(int rowNumber);
    }
}
