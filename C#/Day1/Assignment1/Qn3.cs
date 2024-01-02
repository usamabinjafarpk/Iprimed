using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn3
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter the first number:");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers between " + a + " and " + b + " is,");
            for(int i = a+1; i < b; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
