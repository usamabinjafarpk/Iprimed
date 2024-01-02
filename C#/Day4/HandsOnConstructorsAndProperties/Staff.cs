using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConstructorsAndProperties
{
    internal class Staff
    {
        public int id;
        public string name;

        public Staff(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public Staff(Staff staff)
        {
            this.id = staff.id;
            this.name = staff.name;
        }
        public void Display()
        {
            Console.WriteLine($"Id:{id} Name:{name}");
        }
    }
    class Staff_main
    {
        public static void Main(string[] args)
        {
            Staff s = new Staff(123,"asd");
            s.Display();
            Staff s1 = new Staff(412,"dfg");
            s1.Display();
            Staff[] staffs =new Staff[3];
            staffs[0] = s;//shallow copy
            s.name = "xde";
            staffs[1] = new Staff(231,"qwe");
            staffs[2] = new Staff(s1);//deep copy
            s1.name = "zxc";
            foreach(Staff f in staffs)
            {
                f.Display();
            }
            Staff s2= s;
            s2.Display();

        }
    } 
}
