using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Class4
    {
        static void Add(int a, int b)
        {
            int r = 0;
            r = a + b;
            Console.WriteLine(r);
        }
        static void Add(int a,int b,int c)
        {
            int r = 0;
            r = a + b + c;
            Console.WriteLine(r);
        }
        static void Add(double a,double b)
        {
            double r = 0;
            r= a + b;
            Console.WriteLine(r);
        }
        static void Main()
        {
            Add(2, 3);
            Add(2, 3,1);
            Add(2.1, 3.0);

        }
    }
}
