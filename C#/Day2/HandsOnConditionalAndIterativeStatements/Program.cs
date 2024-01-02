namespace HandsOnConditionalAndIterativeStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string ?name=Console.ReadLine();
            Console.WriteLine("Enter the age:");
            int age=int.Parse(Console.ReadLine());
            if(age > 18) {
                Console.WriteLine($"{name}, Allow to exam");
            }
            else
            {
                Console.WriteLine("Not allowed");
            }
        }
    }
}
