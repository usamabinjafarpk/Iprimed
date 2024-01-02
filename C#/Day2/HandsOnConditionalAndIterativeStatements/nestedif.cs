using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalAndIterativeStatements
{
    internal class nestedif
    {
        static void Main(string[] args)
        {
            int a=12; int b=13; int c=14;
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine($"{a} is greater");
                }
                else {
                    Console.WriteLine($"{c} is greater");
                }
            }
            else
            {
                if(b > c)
                {
                    Console.WriteLine($"{b} is greater");
                }
                else
                {
                    Console.WriteLine($"{c}greater");
                }
            }
        }
    }
}
