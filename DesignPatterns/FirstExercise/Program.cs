using FirstExercise.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace FirstExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(5, 3);
            Compute(rectangle);

            var triangle = new Triangle(3, 4, 4, 5);
            Compute(triangle);

            ConsumerReceivesCorrectValues();

            var univeristy = new Base();
            univeristy.ShowData();
            Console.ReadKey();
        }

        public static void Compute(Shape shape)
        {
            var area = shape.ComputeArea();
            var perimeter = shape.ComputePerimeter();

            Console.WriteLine($"Area: {area}, Perimeter: {perimeter}\n\n");
        }

        private static void Produce(BufferBlock<int> queue, int queueSize)
        {
            var random = new Random();

            for (var i = 0; i < queueSize; i++)
            {
                queue.Post(random.Next(1, 100));
            }

            queue.Complete();
        }

        private static async Task<IEnumerable<int>> Consume(BufferBlock<int> queue)
        {
            var ret = new List<int>();
            while (await queue.OutputAvailableAsync())
            {
                ret.Add(await queue.ReceiveAsync());
            }

            return ret;
        }

        public static async Task ConsumerReceivesCorrectValues()
        {
            var queue = new BufferBlock<int>();

            Produce(queue, 100);
            var consumer = Consume(queue);

            // Wait for everything to complete.
            await Task.WhenAll(consumer, queue.Completion);
        }
    }
}
