namespace HandsOnGenericCollection
{
    //generic classes
    class Sample<T>
    {
        public T a;
        public T b;

        public void Details(T t,T j)
        {
            a=t; b=j;
            Console.WriteLine($"a={a} b={b}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample<int> obj = new Sample<int>();
            obj.a = 1;
            obj.b = 2;
            obj.Details(1,2);
            Sample<char> obj1=new Sample<char>();
            obj1.a = 'a';
            obj1.b = 'b';
            obj1.Details('a', 'b');
            Sample<string> obj2 = new Sample<string>();
            obj2.a = "asd";
            obj2.Details("hi", "Hello");
        }
    }
}
