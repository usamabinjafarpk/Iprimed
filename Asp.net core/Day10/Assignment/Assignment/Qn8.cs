using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Qn8
    {
        static void Main(string[] args)
        {
            //8. Rewrite the last two example of that used Count using LINQ query methods entirely.
            List<Order> list = new List<Order>()
            {
                new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809),
                 new Order(5,"eraser",new DateTime(2024,01,05),800)
            };

            int objs = (list.Where(ord => ord.Qty == 0)).Count();


            if (objs <= 0)
            {
                Console.WriteLine("No orders below 0");
            }



            var resultFinal = list.OrderByDescending(ord => ord.date).ToList();



            Console.WriteLine($"The order with largest quantity: {resultFinal.First().ItemName}");


            int objsJan2024 = (list.Where(ord => ord.date.Year < 2024)).Count();


            if (objsJan2024 > 0)
            {
                Console.WriteLine($"There are {objsJan2024} orders before Jan2024");
            }


        }
    }
}

