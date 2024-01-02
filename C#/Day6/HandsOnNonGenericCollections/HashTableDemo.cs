using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnNonGenericCollections
{
    internal class HashTableDemo
    {
        static void Main()
        {
            Hashtable ht= new Hashtable();
            ht.Add(121, "asd");
            ht.Add(111, "qwe");
            ht.Add(222, "qwe");
            ht.Add(333, "ert");
            string name = ht[333].ToString();
            Console.WriteLine(name);
            ht.Remove(333);
            foreach(int k in ht.Keys)
            {
                Console.WriteLine($"Id:{k} Name:{ht[k]}");
            }
            Console.WriteLine();
            SortedList sl = new SortedList();
            sl.Add(121, "asd");
            sl.Add(111, "qwe");
            sl.Add(222, "qwe");
            sl.Add(333, "ert");
            foreach (int k in sl.Keys)
            {
                Console.WriteLine($"Id:{k} Name:{sl[k]}");
            }
        }
    }
}
