using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            string[,] log = new string[4, 2] {
            {"abc","1234" },
            {"cde","1234" },
            {"efg","1234" },
            {"ghi","1234" },
            };
            bool flag = false;
            Console.WriteLine("Enter the username:");
            string username= Console.ReadLine();
            Console.WriteLine("Enter the password:");
            string password= Console.ReadLine();
            for(int i = 0; i < 4; i++)
            {
                if (log[i,0]==username && log[i,1]==password)
                {
                    flag = true;
                    break;
                }
            }
            if(flag)
            {
                Console.WriteLine("Valid user");
            }
            else {
                Console.WriteLine("Invalid user");

            }
        }
    }
}
