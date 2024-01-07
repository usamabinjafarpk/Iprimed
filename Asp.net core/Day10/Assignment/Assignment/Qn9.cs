using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Qn9
    {
        static void Main(string[] args)
        {
            //9. Given the array of numbers. Count and display even numbers.
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, };
            var res= from i in arr
                     where i%2==0
                     select i;
            var count=res.Count();
            Console.WriteLine("Count="+count);
            foreach( var i in res )
            {
                Console.WriteLine(i);
            }

        }
    }
}
