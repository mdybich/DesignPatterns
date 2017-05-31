using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExercise
{
    public class Producer
    {
        private const int MIN = 1;
        private const int MAX = 100;

        private List<int> queue;

        public Producer(int queueLength)
        {
            queue = new List<int>();

            var random = new Random();
            for (var i = 0; i < queueLength; i++)
            {
                queue.Add(random.Next(MIN, MAX));
            }
        }

        public int GetValue(int value)
        {
            var foundValue = queue.FirstOrDefault(q => q == value);

            if (foundValue == 0)
            {
                throw new Exception("Could not find value!");
            }

            queue.Remove(foundValue);

            return foundValue;
        }
    }
}
