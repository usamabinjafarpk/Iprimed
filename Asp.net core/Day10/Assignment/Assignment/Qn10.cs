using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Qn10
    {
        static void Main(string[] args)
        {
            /*10.Write LINQ to get the sum of quantities for each item and also find out and display
            the item that has overall maximum orders.*/
            List <Order> list = new List<Order>()
            {
                 new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809),
                 new Order(5,"eraser",new DateTime(2024,01,05),800),
            };


            var res = from i in list
                      select i.Qty;
            Console.WriteLine("Sum of qty:"+res.Sum());
            Console.WriteLine();
            var res1=list.OrderByDescending(i => i.Qty);
            foreach (var i in res1)
                Console.WriteLine($"Id:{i.OrderId} Item Name:{i.ItemName} Order date:{i.date} Qty:{i.Qty}");
        }
    }
}
