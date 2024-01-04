using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            string[] flowers = { "rose", "tulip", "lotus" };
            string[] fruits = { "apple", "orange", "mango" };

            var res=from item in flowers
                    where item.Length>4
                    select item.ToUpper();
            foreach(var r in res)
            {
                Console.WriteLine(r);
            }
            var res1=from item in fruits
                     orderby item
                     select item;
            var res2=from item in fruits
                     select item.Length;
            Console.WriteLine();
            foreach(var r in res1)
            {
                Console.WriteLine(r.ToUpper());
            }
        }
    }
}
