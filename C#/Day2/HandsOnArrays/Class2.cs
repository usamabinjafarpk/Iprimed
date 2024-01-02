using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] n = { 121, 32, 43 };
            Console.WriteLine("Length=" + n.Length);
            Console.WriteLine("Dimension=" + n.Rank);
            Array.Sort(n);
            foreach (int i in n) Console.WriteLine(i);
            
            if (Array.BinarySearch(n, 32) == 0)
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not in the array");
            }
            Array.Reverse(n);
            foreach (int i in n) Console.WriteLine(i);
        }
    }
}
