using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int k = 34;
            double d = 34.43;
            decimal dd = 54.2345m;
            //value type to obj
            //implicite
            object o1 = k;
            object o2 = d;
            object o3 = dd;

            //obj to value
            object o4 = 34;
            object o5 = 23.45;
            int n=(int)o4;
            
            Console.WriteLine(n + " " );


        }
    }
}
