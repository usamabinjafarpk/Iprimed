using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1); 
            list.Add(2);
            list.Add(3);
            list.Add(4);
            Console.WriteLine(list.Count);
            Console.WriteLine();
            list.Remove(1);
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Reverse();
            Console.WriteLine();
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
