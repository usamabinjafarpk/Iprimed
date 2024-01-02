using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn6
    {
        static void Main(string[] args)
        {
            int cel;
            Console.WriteLine("Enter the temperature in fahrenheit:");
            int far = int.Parse(Console.ReadLine());
            cel = ((far - 32) * (5 / 4));
            Console.WriteLine(cel);
        }
    }
}
