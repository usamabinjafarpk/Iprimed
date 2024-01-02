using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties_1
{
    internal class Student
    {
        private int id;
        private string name;
        private int[] marks = {79,89,90,99,89,98,97};
        private int total;

        public int ID
        {
            get { return id; }//get value of private variable
            set { id = value; }
        }
        public string NAME
        {
            get { return name; }
            set { name = value; }
        }
        public int Marks
        {
            
            get
            {
                total = 0;
                foreach(int i in marks)
                {
                    total += i;
                }
                return total;
            }
           
        }
        public string Grade
        {
            get
            {
                if (total >= 600)
                {
                    return "A+";
                }
                else if(total >= 500)
                {
                    return "A";
                }
                else if( total >= 400)
                {
                    return "B";
                }
                else
                {
                    return "C";
                }
            }
        }

    }
    class Test_Main
    {
        static void Main()
        {
            Student s = new Student();
            s.ID = 121;
            s.NAME = "Test";
            Console.WriteLine($"Id:{s.ID} Name:{s.NAME} Total Mark:{s.Marks} Grade:{s.Grade}");
        }
    }
}
