using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn7
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int diff = 3;
            Console.WriteLine(first);
            Console.WriteLine(second);
            for (int i = 0; i < 26; i++)
            {
                int third = second + diff;
                Console.WriteLine(third);
                second = third;
                diff = diff + 2;
            }
        }
    }
}
