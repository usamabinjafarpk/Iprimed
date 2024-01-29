using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Qn2
    {
        public static void Main(string[] args)
        {
            /*  2.Write a C# program that performs the following operations on an array of integers:
                  Find the sum of all elements.
                  Find the average of all elements.
                  Find the maximum and minimum values.*/
            int[] num = {10,20,30,40 };
            Console.WriteLine("sum of all elements=" + num.Sum());
            Console.WriteLine("average of all elements=" + num.Average());
            Console.WriteLine("maximum=" + num.Max());
            Console.WriteLine("minimum=" + num.Min());

        }
    }
}
