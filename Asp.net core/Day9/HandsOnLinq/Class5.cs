using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Enroll
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public Enroll(int id, string name)
        {
            this.Id = id;
            this.CourseName = name;
        }
    }
    class StudentEnroll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public StudentEnroll(int id, string name,
                           string cname)
        {
            this.Id = id;
            this.Name = name;
            this.CourseName = cname;
        }
    }


    internal class Class5
    {
     static void Main()
        {
            Student[] students =
     {
            new Student(1,"Asd"),
            new Student(2,"Sdf"),
            new Student(3,"Dfg"),
            new Student(4,"Fgh")
        };
            Enroll[] enrollment =
            {
            new Enroll(1,"c"),
            new Enroll(2,"c++"),
            new Enroll(3,"c#"),
            new Enroll(4,"java")
        };

            /*var res = from s in students
                      join e in enrollment
                      on s.Id equals e.Id
                      select new StudentEnroll (s.Id,s.Name, e.CourseName );*/

            //using annonymous obj
            var res=from student in students
                    join e in enrollment
                    on student.Id equals e.Id
                    select new {id=student.Id,name=student.Name,course=e.CourseName};
            foreach(var i in res)
            {
                Console.WriteLine($" id:{i.id} Name:{i.name} Course:{i.course}");
            }
        }
    }
}
