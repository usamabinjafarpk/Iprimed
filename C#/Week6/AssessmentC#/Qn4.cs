using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Qn4
    {
        /*4.	Create a C# program to print the following pattern:
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5*/
        public static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
