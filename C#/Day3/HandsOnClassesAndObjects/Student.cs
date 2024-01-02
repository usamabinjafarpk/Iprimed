using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Student
    {
        public int id;
        public string name;
        public byte age;
        public char gender;

        public void Display() 
        {
            Console.WriteLine($"Id:{id} name:{name} Age:{age} Gender:{gender}");
        }
        public void Accept() 
        {
            Console.WriteLine("Enter the id:");
            id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age:");
            age=byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the gender:");
            gender=char.Parse(Console.ReadLine());

        }
    }
}
