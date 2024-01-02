using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine(queue.Count);
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            foreach (int i in queue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Deleted item:"+queue.Dequeue());
            Console.WriteLine();
            foreach (int i in queue)
            { Console.WriteLine(i); }
            queue.Clear();
        }
    }
}
