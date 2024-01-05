using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment
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
    internal class Qn2
    {
        static void Main(string[] args)
        {
            /*2.Given a list of participants for a tennis match.Split the list into 2 equal halves and display all the possible combination
                of matches possible between the participants in the two lists.A condition is that no player should have an opponent who is
                from his own his own country.*/
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
                var res = from p1 in list1
                          from p2 in list2
                          where p1.Country != p2.Country
                          select new { op1 = p1.Name, op2 = p2.Name };
                foreach (var p in res)
                    Console.WriteLine($"{p.op1}*{p.op2}");
            }
        }
    }
}
