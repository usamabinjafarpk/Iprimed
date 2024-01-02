namespace HandsOnExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] n = { 1, 2, 3, 4, 5 };
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(n[i]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
