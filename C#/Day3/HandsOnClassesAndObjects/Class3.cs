//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HandsOnClassesAndObjects
//{
//    internal class Class3
//    {
//        public int Sum(int[] a)
//        {
//            int res = 0;
//            foreach (int i in a)
//            {
//                res += i;
                
//            }
//            return res;
//        }
//        //public int Sum(params int[] a)
//        //{
//        //    int res = 0;
//        //    foreach (int i in a)
//        //    {
//        //        res += i;
//        //        return res;
//        //    }
//        //}
//        public string Flowers()
//        {
//            string[] flowers = { "Rose", "Jasmin", "Lilly" };
//            return flowers;
//        }
//        static void Main()
//        {
//            Class3 c = new Class3();
//            int r = c.Sum(new int[] { 1, 2, 3 });
//            Console.WriteLine(r);
//            int[] n = { 1, 2, 3 };
//            Console.WriteLine(c.Sum(n));
//            string[] s = c.Flowers();
//            foreach (string s2 in s)
//            {
//                Console.WriteLine(s2);
//            }
//            r = c.Sum(1, 2, 3, 4);
//            Console.WriteLine(r);

//        }
//    }
//}
