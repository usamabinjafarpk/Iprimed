namespace HandsOnArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];

            int count = 0;
            int c = 0;
            int total = 0;
            num[0]= 1;
            num[1]= 2;
            num[2]= 3;
            for(int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
                total += num[i];
            }
            Console.WriteLine();
            foreach(int i in num)
            {
                Console.WriteLine(i);
                count++;
            }
            Console.WriteLine("Count= "+count);
            Console.WriteLine("Total= "+total);
            Console.WriteLine("Enter:");
            string s= Console.ReadLine();
            foreach(int i in s)
            {
                c++;
            }
            Console.WriteLine(c);
        }
    }
}
