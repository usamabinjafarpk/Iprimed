using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTypeConversion
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the gender");
            char gender = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter the Emp id:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the salary");
            double salary=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Employee details");
            Console.WriteLine($"Name:{name} Gender:{gender} Emp Id:{id} Salary:{salary}");

        }
    }
}
