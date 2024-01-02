using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Class1
    {
        private int a;
        public void Message()
        {
            Console.WriteLine("A=" + a);
        }
        public void Seta()
        {
           a = 10;
        }
        public void Greeting(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        public void Add(int a,int b)
        {
            int c;
            c = a + b;
            Console.WriteLine("Sum=" + c);
        }
    }
    class test
    {
        static void Main()
        {
            Class1 c = new Class1();
            c.Message();
            c.Seta();
            c.Message();
            c.Greeting("Usama");
            c.Add(1,2);
        }
    }
}
