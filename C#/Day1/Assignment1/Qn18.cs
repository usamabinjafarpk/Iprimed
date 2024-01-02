using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn18
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the string:");
            string str = Console.ReadLine();
            int l = str.Length;
            for (int i = 0, j = l - 1; i < l; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag++;
                    break;
                }

            }
            if (flag == 0)
            {
                Console.WriteLine("Palidrom");
            }
            else
            {
                Console.WriteLine("Not palindrom");
            }
        }
    }
}
