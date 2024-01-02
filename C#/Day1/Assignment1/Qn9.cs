using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn9
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 0; i < 38; i++)
            {
                int third = first + second;
                Console.WriteLine(third);
                first = second;
                second = third;
            }
        }
    }
}
