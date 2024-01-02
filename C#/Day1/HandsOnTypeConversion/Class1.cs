using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string s = "23";
            int i = int.Parse(s);
            byte b =byte.Parse(s);
            short s1 = short.Parse(s);
            double d1 = double.Parse(s);
            float f1 = float.Parse(s);
            decimal c1 = decimal.Parse(s);
            Console.WriteLine(c1);
            //
            int a = 234;
            string ss=a.ToString();
            Console.WriteLine(ss);
        }
    }
}
