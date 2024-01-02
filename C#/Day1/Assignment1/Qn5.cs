using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn5
    {
        static void Main(string[] args)
        {
            int[] oddev = new int[10];
            int lim;
            int oc = 0, ec = 0;
            Console.WriteLine("Enter the limit:");
            lim = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers");
            for(int i = 0; i < lim; i++)
            {
                oddev[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < lim; i++)
            {
                if (oddev[i] % 2 == 0)
                {
                    ec++;
                }
                else
                {
                    oc++;
                }
            }
            Console.WriteLine($"Odd number={oc} Even number={ec}");

        }
    }
}
