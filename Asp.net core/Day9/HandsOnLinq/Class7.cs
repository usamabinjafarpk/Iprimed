using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class7
    {
        class Student
        {
            public Student(int id, string name)
            {
                Id = id;
                Name = name;
            }

            public int Id { get; set; }
            public string Name { get; set; }

        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1,"hari"),
                new Student(2,"ravi"),
                new Student(3,"amall"),
                new Student(4,"annaaa")

            };
            Student s=students.First();
            Console.WriteLine(s.Name);
            s=students.Where(s=>s.Name.Length>4).First();
            Console.WriteLine(s.Name);
            s=students.Last();
            Console.WriteLine(s.Name);
            s=students.Where(e=>e.Name.Length>4).Last();
            Console.WriteLine(s.Name);
            s = students.Where(e => e.Name.Length > 14).FirstOrDefault();
            if(s!=null) Console.WriteLine(s.Name);
            s = students.Single(s => s.Id == 3);
            Console.WriteLine();
            Console.WriteLine(s.Name);
            Console.WriteLine();
            s=students.SingleOrDefault(s => s.Id == 5);
            if(s!=null) Console.WriteLine( s.Name);
            List<Student> list1=students.Where(s=>s.Name.Length>3).ToList();
            foreach(var i in list1)
            {
                Console.WriteLine(i.Name);
            }
            Student[] std1=students.Where(e=>e.Name.Length>3).ToArray();
            Console.WriteLine();
            foreach(var i in std1) Console.WriteLine(i.Name);
            Student s1=students.Where(s=>s.Name.Length>3).ElementAt(0);
            s1 = students.Where(e => e.Name.Length > 4).ElementAt(1);
            Console.WriteLine();
            Console.WriteLine(s1.Name);
        }
    }
}


