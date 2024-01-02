namespace HandsOnTypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicite
            byte a = 1;
            short b = a;
            int c= b;
            Console.WriteLine(c);

            //Explicite
            int d = 345;
            short e =(short)d;
            Console.WriteLine(e);

            double f = 34.67;
            short g = (short)f;
            Console.WriteLine(g);

            //convert decimal to int,byte,short,long,double,float
            decimal dd = 34.567m;
            int ii=(int)dd;
            byte bb=(byte)ii;
            short ss=bb;
            long ll=ss;
            double dub = ll;
            Console.WriteLine(dub);

        }
    }
}
