using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassTypes
{
    class A
    {
        public void M() { }
    }
    sealed class B:A 
    {
        public void M1()
        {

        }
    }
    class C 
    {

    }
    internal class Sealed
    {
        static void Main(string[] args)
        {
            B obj=new B();
            obj.M1();
            obj.M();
        }
    }
}
