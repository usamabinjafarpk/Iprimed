using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    class Student
    {
        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id {  get; set; }
        public string Name { get; set; }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "Rose", "Lilly", "Jasmin" };
            List<bool> lst = new List<bool> { true, false,false,true };
            List<Student> list1 = new List<Student>()
            {
                new Student(123,"asd"),
                new Student(234,"sdf")
            };
            list1.Add(new Student(345, "qwe"));
            Student s = list1[1];
            Console.WriteLine(s.Name);
            Console.WriteLine();
            foreach (Student s1 in list1)
            {
                Console.WriteLine($"Id={s1.Id} Name={s1.Name}");
            }
        }
    }
}
