using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    internal class Qn3
    {
        /*3.	Write a C# program to generate and display the first N prime numbers, where N is provided by the user.*/
        static bool isPrime(int n)
        {
            if (n == 1 || n == 0) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter a limit:");
            int num =int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
