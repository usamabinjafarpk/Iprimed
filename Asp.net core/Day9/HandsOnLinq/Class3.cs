using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Player
    {
        public Player(string name, string country)
        {
            Name = name;
            Country = country;
        }

        public string Name { get; set; }
        public string Country { get; set; }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            List<Player> list1 = new List<Player>()
        {
            new Player("player1","Ind"),
            new Player("player2","Us")
        };
            List<Player> list2 = new List<Player>()
        {
            new Player("player3","Ind"),
            new Player("player4","UK")
        };
            var res=from p1 in list1
                    from p2 in list2
                    where p1.Country!=p2.Country
                    select new {op1=p1.Name,op2=p2.Name};
            foreach(var  p in res)
                Console.WriteLine($"{p.op1}*{p.op2}");
        }
      
        
       

    }
}
