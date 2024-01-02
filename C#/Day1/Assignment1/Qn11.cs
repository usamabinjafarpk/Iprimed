using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn11
    {
        static void Main(string[] args)
        {
            int a = 200;
            int b = 300;
            for (int i = a; i < b; i++)
            {
                if(i%7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
