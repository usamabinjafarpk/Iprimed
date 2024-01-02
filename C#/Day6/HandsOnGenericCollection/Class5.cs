using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    internal class Class5
    {
        static void Main()
        {
            Dictionary<int,string> obj = new Dictionary<int,string>();
            obj.Add(123, "asd");
            obj.Add(234, "qwe");
            obj.Add(345, "wer");
            obj.Add(456, "afd");
            string name = obj[234];
            Console.WriteLine(name);
            foreach (var item in obj.Keys)
            {
                Console.WriteLine($"Id:{item} Name:{obj[item]}");
            }
            Teacher t1 = new Teacher() { Id=213,Name="usama",Email="u@g.c", Mobile="90867",School="qwe"};
            Teacher t2 = new Teacher() { Id = 234, Name = "qaz", Email = "q@g.c", Mobile = "90862", School = "asd" };
            Teacher t3 = new Teacher() { Id = 433, Name = "xsw", Email = "c@g.c", Mobile = "90861", School = "qwe" };
            Dictionary<int,Teacher> ob = new Dictionary<int,Teacher>();
            ob.Add(t1.Id, t1);
            ob.Add(t2.Id, t2);
            ob.Add(t3.Id, t3);
            Teacher t = ob[t1.Id];
            Console.WriteLine($"{t.Name} {t.Email}");

        }
    }
}
