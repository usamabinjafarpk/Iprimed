namespace HandsOnInterfaces
{
    public interface IShape
    {
        void Area();
    }
    class Circle : IShape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius=radius;
        }

        public void Area()
        {
            Console.WriteLine("Area:" + Math.PI * radius * radius);
        }
        public void GetShape()
        {
            Console.WriteLine("Its circle");
        }
    }
    class Rectangle : IShape
    {
        private int l, w;
        public Rectangle(int l, int w)
        {
            this.l=l;
            this.w=w;
        }

        public void Area()
        {
            Console.WriteLine("Area:"+ l*w);
        }
        public void GetShape()
        {
            Console.WriteLine("Rectangle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius");
            double r=Convert.ToDouble(Console.ReadLine());
            Circle cr = new Circle(r);
            cr.Area();
            cr.GetShape();
            Rectangle rl = new Rectangle(10,10);
            rl.Area();
            rl.GetShape();
            IShape circle =new Circle(10);
            circle.Area();
            IShape rl1 =new Rectangle(10,10);
            rl1.Area();
        }
    }
}
