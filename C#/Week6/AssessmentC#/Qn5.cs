using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assessment
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

    class Enrollment
    {
        public Enrollment(int studentId, string course)
        {
            StudentId = studentId;
            Course = course;
        }

        public int StudentId { get; set; }
        public string Course { get; set; }
    }
    internal class Qn5
    {
        public static void Main(string[] args)
        {
           /* 5.Create two lists: one with student information(ID, Name) and another with course enrollment information(StudentID, Course). Write a LINQ query to retrieve a list of students along with the courses they are enrolled in.*/
            List<Student> list1 = new List<Student>()
            {
                new Student(123,"Anu"),
                new Student(234,"Vinu")
            };
            List<Enrollment> list2 = new List<Enrollment>()
            {
                new Enrollment(123,"C#"),
                new Enrollment(234,"C++")
            };

            var studlist = from i in list1
                           join j in list2
                           on i.Id equals j.StudentId
                           select (i,j);
            foreach (var student in studlist)
            {
                Console.WriteLine($"Id: {student.i.Id}, Name: {student.i.Name}, Course: {student.j.Course}");
            }

        }
    }
}
