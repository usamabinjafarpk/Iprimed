using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn8
    {
        static void Main(string[] args)
        {
            int n;
            int fact = 1;
            Console.WriteLine("Enter the number:");
            n=int.Parse(Console.ReadLine());
            for(int i = n; i > 0; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
    }
}
