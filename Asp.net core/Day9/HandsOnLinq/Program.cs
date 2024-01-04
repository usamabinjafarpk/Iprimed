namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = {  5, 6, 7, 8, 1, 2, 3, 4, 9, 10, 11, 12, 13, 14, };
            var result=from k in n
                       where k > 8
                       select k;
            var res = from k in n
                      select k * k;
            res=from k in n
                     where k*k > 100
                     select k*k;
            res = from k in n
                  let i = k * k
                  select i;
            res = from k in n
                  let i=k*k
                  where i>100
                  select i;
            res = from k in n
                  orderby k
                  select k;
            res = from k in n
                  orderby k descending
                  select k;
            res = from k in n
                  let i = k * k
                  where i > 100 && i < 150
                  select i;
         
            

            foreach (var v in result)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
            foreach (var v in res)
            {
                Console.WriteLine(v);
            }
        }
    }
}
