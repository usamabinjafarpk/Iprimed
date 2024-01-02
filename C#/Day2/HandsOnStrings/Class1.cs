using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnStrings
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            StringBuilder obj = new StringBuilder();
            obj.Append("Good Morning");
            Console.WriteLine(obj);
            obj.Replace("Morning", "Evening");
            Console.WriteLine(obj);
            string s = "Good morning";
            Console.WriteLine(s);
            s.Replace("morning", "evening");
            Console.WriteLine(s);
        }
    }
}
