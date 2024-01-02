using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Qn13
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter the 5 numbers:");
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            int small = num[0];
            for (int i = 0; i < num.Length; i++)
            {
                if (small > num[i])
                {
                    small = num[i];
                }
            }
            Console.WriteLine(small);
        }
    
}
}
