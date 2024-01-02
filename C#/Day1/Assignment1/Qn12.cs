using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn12
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter 3 numbers:");
            a=int.Parse(Console.ReadLine());
            b=int.Parse(Console.ReadLine());
            c=int.Parse(Console.ReadLine());
            if(a>b)
            {
                if(a>c)
                {
                    Console.WriteLine(a + " is larger...");
                }
                else
                {
                    Console.WriteLine(c + " is larger...");
                }
            }
            else if(b>c)
            {
                if(b>a) {
                    Console.WriteLine(b + " is larger...");
                }
                else
                {
                    Console.WriteLine(a + " is larger...");
                }
            }
            else
            {
                Console.WriteLine(c + " is larger...");
            }
        }
    }
}
