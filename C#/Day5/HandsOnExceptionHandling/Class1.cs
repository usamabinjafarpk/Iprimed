using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            try
            {
                byte a, b;
                Console.WriteLine("Enter 2 numbers:");
                a = byte.Parse(Console.ReadLine());
                b = byte.Parse(Console.ReadLine());
                if (b == 0)
                {
                    throw new Exception("B should not be zero");
                }
                else
                {
                    int c = a / b;
                    Console.WriteLine(c);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
