using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<Flower> list = new List<Flower>();
            list.Add(new Flower("Tulip", 5));
            list.Add(new Flower("lotus", 5));
            list.Add(new Flower("lily", 20));
            list.Add(new Flower("daffodil", 5));
            list.Add(new Flower("hibiscus", 6));
            //fetch flowers whose name starts with d
            var result = from f in list
                         where f.Name.StartsWith("d")
                         select f;
            foreach (var f in result)
            {
                Console.WriteLine($"Name:{f.Name} Petals:{f.Petals}");

            }
            //fetch flowers whose petyals are equal to 5
            result = from f in list
                     where f.Petals == 5
                     select f;
            //fetch flowers whose name starts with d and with 5 petals
            result = from f in list
                     where f.Petals == 5 && f.Name.StartsWith("d")
                     select f;
            //fetch flower with name lily
            result = from p in list
                     where p.Name == "lily"
                     select p;
            //fetch all flower in an ascending order
            result = from p in list
                     orderby p.Name ascending
                     select p;
            //fetch all flowers in an descending order of petals
            result = from p in list
                     orderby p.Petals descending
                     select p;
            var lquery = from Flower flower in list
                         orderby flower.Petals
                         group flower by flower.Petals;
            foreach(var f in lquery)
            {
                Console.WriteLine("Flowers with " + f.Key + "Petals");
                foreach (var n in f)
                    Console.WriteLine(" " + n.Name);
            }

        }
    }
}
