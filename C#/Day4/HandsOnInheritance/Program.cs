namespace HandsOnInheritance
{
    internal class Program
    {
        class I
        {
            protected int a;
            protected int b;

            public I(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
        }
        class J:I
        {
            public J():base(3,5)
            {

            }
            public J(int x, int y):base(x,y)
            {

            }
            public void f()
            {
                Console.WriteLine($"a={a} b={b}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            J obj = new J();
            obj.f();
            J obj2 = new J(12,23);
            obj2.f();
        }
    }
}
