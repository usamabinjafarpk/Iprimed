using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
    internal class Qn7
    {
        static void Main(string[] args)
        {
            //7.Check if all the quantities in the Order collection is > 0.
           /* Get the name of the item that was ordered in largest quantity in a single order. (Hint: use LINQ methods to sort)
            Find if there are any orders placed before Jan of this year.
*/
            List<Order> list = new List<Order>()
            {
                new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
            var result = from s in list
                         where s.Qty < 0
                         select s;
        
            if (result != null)
            {
                Console.WriteLine("All the quantities in the Order collection is > 0.");
            }


            var result1=list.OrderByDescending(o=>o.Qty).First();
            Console.WriteLine(result1.ItemName);

            var result2 = from s in list
                          where s.date < DateTime.Now();

        }
    }
}
