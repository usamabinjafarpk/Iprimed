using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Class2
    {
        public string Greet(string name)
        {
            return "Hello" + name;
        }
        public double Square(double a)
        {
            double r = a * a;
            return r;
        }
        public bool IsEven(int num)
        {
            return num%2==0 ? true : false;
        }
        public int Add(int a,int b=11)
        {
            return a + b;
        }
        static void Main()
        {
            Class2 c = new Class2();
            string res = c.Greet("Usama");
            Console.WriteLine(res);
            Console.WriteLine(c.Square(10));
            Console.WriteLine(c.IsEven(23)?"Even":"Odd");
            Console.WriteLine(c.Add(23));
        }
    }
}
