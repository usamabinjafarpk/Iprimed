using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Staff
    {
        public int staffId;
        public string staffName;
        public static string school;
        public static string branch;
        public const string city = "Tvm";

        public string Display()
        {
            return $"Id:{staffId} Name:{staffName} School:{school} Branch:{branch} City:{city}";

        }
        static void Main()
        {
            Staff.school = "DPS";
            Staff.branch = "abc";
            Staff s1= new Staff() { staffId=1234,staffName="qwe"};
            Staff s2 = new Staff() { staffId = 2345, staffName = "ert" };
            Staff s3 = new Staff() { staffId = 3456, staffName = "rty" };
            Console.WriteLine(s1.Display());
            Console.WriteLine(s2.Display());
            Console.WriteLine(s3.Display());
            Staff.branch = "cde";
            Staff s4 = new Staff() { staffId = 4567, staffName = "tyu" };
            Staff s5 = new Staff() { staffId = 5678, staffName = "yui" };
            Console.WriteLine(s4.Display());
            Console.WriteLine(s5.Display());


        }
    }
}
