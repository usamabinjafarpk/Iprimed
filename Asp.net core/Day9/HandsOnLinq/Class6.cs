using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahliya", "rose", "lotus", "lilly", "hibiscus", "daffodil" };
            IEnumerable<string> f = flowers.Where(flower => flower.StartsWith("d"));
            foreach(string a in f)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();
            f = flowers.OrderBy(e => e);
            foreach(string a in f)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            var res = flowers.GroupBy(e => e.Length);
            foreach (var a in res)
            {
                Console.WriteLine("Flowers with length:"+a.Key);
                foreach(var b in a) Console.WriteLine(b);
            }
        }
    }
}
