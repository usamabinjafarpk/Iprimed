using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[,] num = new int[3, 2];
            num[0, 0] = 21;
            num[0, 1] =32;
            num[1, 0] = 65;
            num[1, 1] = 78;
            num[2, 0] = 64;
            num[2, 1] = 12;

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.Write(num[i,j]+" ");
                }
                Console.WriteLine() ;
            }
           

        }
    }
}
