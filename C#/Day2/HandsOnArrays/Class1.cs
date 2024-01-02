using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string[] name =
            {
                "abc",
                "cde",
                "efg",
                "ghi"
            };
            bool flag = false;
            Console.WriteLine("Enter the name:");
            string ip = Console.ReadLine();
            foreach(string s in name)
            {
                if (s ==ip)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine($"{ip} is selcted");
            }
            else
            {
                Console.WriteLine("Not selected");
            }
        }
    }
}
