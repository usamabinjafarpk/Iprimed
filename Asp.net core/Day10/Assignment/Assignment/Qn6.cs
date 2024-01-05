using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment
{
   
    internal class Qn6
    {
        static void Main(string[] args)
        {
            //6.Do the previous exercise using anonymous types.
            List<Order> list = new List<Order>()
            {
                new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
            List<Item> list2 = new List<Item>()
            {
                new Item("pencil",10),
                new Item("box",20),
                new Item("pen",15),
                new Item("notes",40)
            };
            var res = from i in list
                      join j in list2
                      on i.ItemName equals j.ItemName
                      select new { id = i.OrderId, name = i.ItemName, dt = i.date, price = (i.Qty * j.Price) };
            var res1 = res.OrderByDescending(o => o.dt.Month);
            foreach (var i in res1)
            {
                Console.WriteLine($"Order Id:{i.id} Item Name:{i.name} Order Date:{i.dt.ToShortDateString()} Total Price:{i.price}");
            }
        }
    }
}
