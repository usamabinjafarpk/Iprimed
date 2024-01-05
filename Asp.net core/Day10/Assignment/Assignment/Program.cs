namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Given an array of numbers. Find the cube of the numbers that are greater than 100 but less than 1000 using LINQ.

            int[] ar = { 5,6,7,11,20, 30, 40, 50, 60 };
            var res1=from i in ar
                     let j=i*i*i
                     where j>100 && j<1000
                     select j;
            foreach(var i in res1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 400 };
            var res = arr.Where(s => s * s * s > 100 && s * s * s < 1000);
            foreach (var i in res)
            {
                Console.WriteLine(i * i * i);
            }

        }
    }
}
