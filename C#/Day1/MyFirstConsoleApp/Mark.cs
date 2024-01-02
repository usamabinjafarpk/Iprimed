using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Mark
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Mark:");
            n=int.Parse(Console.ReadLine());
            Console.WriteLine("Name is: "+name);
            Console.WriteLine("Mark is:" + n);
        }
    }
}
