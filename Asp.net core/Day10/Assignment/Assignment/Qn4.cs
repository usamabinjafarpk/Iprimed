using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment
{
    internal class Qn4
    {
        static void Main(string[] args)
        {
           // 4.For the previous exercise, write a LINQ query that displays the details grouped by the month in the descending order of the order date.
            List<Order> list = new List<Order>()
            {
                new Order(1,"pencil",new DateTime(2001,03,20),89),
                 new Order(2,"box",new DateTime(2000,12,25),890),
                 new Order(3,"pen",new DateTime(1900,07,10),189),
                 new Order(4,"notes",new DateTime(2020,09,05),809)
            };
            
            var res = from order1 in list
                      orderby order1.date descending
                      group order1 by order1.date.Month;

            Console.WriteLine("Details grouped by month in descending order of the order date:");
            foreach (var order in res)
            {
                Console.WriteLine($"Month: {order.Key}");
                foreach (var item in order)
                {
                    Console.WriteLine(item.ItemName);
                }
                Console.WriteLine();
            }
        }
    }
}
