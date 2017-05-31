using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondExercise.Decorator
{
    public abstract class ITreeDecorator : ITree
    {
        private ITree _tree;
        public ITreeDecorator(ITree tree)
        {
            _tree = tree;
        }
        public virtual void Draw()
        {
            _tree.Draw();
        }

        public virtual void DrawRow(int rowNumber)
        {
            _tree.DrawRow(rowNumber);
        }
    }
}
