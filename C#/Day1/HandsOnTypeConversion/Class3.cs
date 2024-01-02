using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            //convert using Convert class
            double d = 32;
            int a = Convert.ToInt32(d);
            string s = "234";
            int n = Convert.ToInt32(s);
            int n1 = Convert.ToInt32("23");
            Console.WriteLine(a);
            Console.WriteLine(s);
            Console.WriteLine(n1);
            string c = "a";
            char c1= Convert.ToChar(c);
            Console.WriteLine(c1);
            
        }
        
    }
}
