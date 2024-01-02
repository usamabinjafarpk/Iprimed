using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClassesAndObjects
{
    internal class Grade
    {
        public static int[] marks;
        public static int total;

        public static int Total()
        {
            int totl = 0;
            foreach(int k in marks)
            {
                totl += k;
            }
            total = totl;
            return total;
        }
        public static string Rank()
        {
            if (total >= 700)
            {
                return "A+";
            }
            else if(total >=600)
            {
                return "A";
            }
            else
            {
                return "B";
            }
        }
        class Test
        {
            static void Main()
            {
                Grade.marks = new int[] { 59, 89, 70, 45, 78, 90 };
                Console.WriteLine($"Total:{Grade.Total()} Grade:{Grade.Rank()}");
            }
        }
    }
}
