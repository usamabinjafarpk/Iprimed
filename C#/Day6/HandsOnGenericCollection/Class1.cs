using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollection
{
    class KeyValue<K, V>
    {
        public K id;
        public V name;
        
        public void Display(K a, V b)
        {
            id = a;
            name=b;
            Console.WriteLine($"id={id} {name}");
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            KeyValue<int,string> ob= new KeyValue<int,string>();
            ob.id = 1;
            ob.name = "test";
            KeyValue<double,char> ob2= new KeyValue<double,char>();
            ob2.id = 2.99;
            ob2.name = 'a';
            ob2.Display(2.99, 'a');
        }
    }
}
