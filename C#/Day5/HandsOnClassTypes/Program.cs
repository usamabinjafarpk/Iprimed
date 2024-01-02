namespace HandsOnClassTypes
{
    static class Converter
    {
        public static int a;
        public static double RTD(double rupees)
        {
            return rupees/78.5;
        }
        public static double DTR(double dollers)
        {
            return dollers * 78.5;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0:C}", Converter.RTD(1000));
            Console.WriteLine(Converter.DTR(100));
        }
    }
}
