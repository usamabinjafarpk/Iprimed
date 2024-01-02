using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Teacher
    {
        private int teacherId;
        private string teacherName;
        private int age;

        public string Name
        {
            get { return teacherName; }
            set
            {
                if (value != null)
                {
                    teacherName = value;
                }
                else
                    Console.WriteLine("Enter a valid name");
            }
        }
        public int ID
        {
            get { return teacherId; }
            set {
                if (value > 0)
                    teacherId = value;
                else
                    Console.WriteLine("Invalid Id");
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 24 && value < 28)
                {
                    age = value;
                }
                else
                    Console.WriteLine("Not eligible for the post");
            }
        }
    }

    class Teacher_Main
    {
        static void Main()
        {
            Teacher obj = new Teacher();
            obj.ID = 1;
            obj.Age = 30;
            obj.Name = null;
            Console.WriteLine($"Id:{obj.ID} Name:{obj.Name} Age:{obj.Age}");
            Teacher obj1 = new Teacher();
            obj1.ID = 2;
            obj1.Age = 25;
            obj1.Name = "zxc";
            Console.WriteLine($"Id:{obj1.ID} Name:{obj1.Name} Age:{obj1.Age}");

        }
    }
}
