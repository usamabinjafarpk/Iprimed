using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace HandsOnGenericCollection
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Picked item:"+stack.Peek());
            Console.WriteLine("Removed item:" + stack.Pop());
            foreach(var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Removed item:" + stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
