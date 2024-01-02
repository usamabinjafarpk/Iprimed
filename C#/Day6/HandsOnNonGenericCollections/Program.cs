using System.Collections;

namespace HandsOnNonGenericCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList obj= new ArrayList();
            obj.Add(1);
            obj.Add("Usama");
            obj.Add('a');
            obj.Add(true);
            obj.Insert(2, 12.4);
            Console.WriteLine(obj.Count);
            foreach (object i in obj)
            {
                Console.WriteLine(i);
            }
            obj.Remove(1);
            Console.WriteLine(obj.Count);
            foreach(var i in obj)
            {
                Console.WriteLine(i);
            }
            var a = 10;
        }
    }
}
