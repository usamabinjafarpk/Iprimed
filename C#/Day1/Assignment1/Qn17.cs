using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first string:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            string s2 = Console.ReadLine();
            if (s1 == s2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not same");
            }

        }
    }
}
