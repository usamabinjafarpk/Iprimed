using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            int count = 0;
            string s=Console.ReadLine();
            foreach(int i in s)
            {
                count++;
            }
            Console.WriteLine("Count="+count);
        }
    }
}
