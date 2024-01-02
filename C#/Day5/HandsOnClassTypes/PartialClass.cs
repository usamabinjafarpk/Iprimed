using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    partial class test
    {
        public void M() {
            Console.WriteLine("M");

        }
    }
    partial class test
    {
        public void M1() {
            Console.WriteLine("M1");
        }
    }
    partial class test
    {
        public void M2() { 
            Console.WriteLine("M2");

        }
    }
    class x : test
    {
        

    }
    internal class PartialClass
    {
        static void Main(string[] args)
        {
            test tst = new test();
            tst.M();
            tst.M1();
            tst.M2();
            x a=new x();
            a.M1();
        }
    }
}
