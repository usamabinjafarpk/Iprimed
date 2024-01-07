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
    class Item
    {
        public Item(string itemName, int price)
        {
            ItemName = itemName;
            Price = price;
        }

        public string ItemName { get; set; }
        public int Price { get; set; }
    }
    class ItemPrint
    {
        public ItemPrint(int orderId, string itemName, DateTime date, int totalPrice)
        {
            OrderId = orderId;
            ItemName = itemName;
            this.date = date;
            TotalPrice = totalPrice;
        }

        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime date { get; set; }
        public int TotalPrice {  get; set; }
    }
    internal class Qn5
    {
        static void Main(string[] args)
        {
            /*5.You have created Order class in the previous exercise and that has order id, item name, order date and quantity.
            Create another class called Item that has item name and  price.Write a LINQ query such that it returns order id, item name,
            order date and the total price(price* quantity) grouped by the month in the descending order of the order date.*/
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
                      select new ItemPrint(i.OrderId, i.ItemName, i.date, (i.Qty * j.Price));
        var res1 = res.OrderByDescending(o => o.date.Month);
            foreach(var i in res1)
            {
                Console.WriteLine($"Order Id:{i.OrderId} Item Name:{i.ItemName} Order Date:{i.date.ToShortDateString()} Total Price:{i.TotalPrice}");
            }
}
    }
}
