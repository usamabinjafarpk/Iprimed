using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Student
    {
        static void Main(string[] args)
        {
            string studentname="Anu";
            char gender='M';
            byte age=15;
            string schoolname="GHSS Abc";
            int std=10;
            char section='A';
            int totalmark = 85;
            float averagemark = 80.7f;
            Console.WriteLine("Name:"+studentname);
            Console.WriteLine("Gender:"+gender);
            Console.WriteLine("Age:"+age);
            Console.WriteLine("School Name:"+schoolname);
            Console.WriteLine("Std:"+std);
            Console.WriteLine("Section:"+section);
            Console.WriteLine("Average mark:"+averagemark);
            Console.WriteLine("Total Mark:" + totalmark);
        }
    }
}
