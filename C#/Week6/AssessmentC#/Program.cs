using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Develop a simple number guessing game in C#. The program should generate a random number between a specified range, and the user should try to guess the number within a limited number of attempts.*/
            int num = new Random().Next(1, 10);
            Console.WriteLine("Enter a number between 1 to 10");
            Console.WriteLine("You have 5 attempts");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Guess {i}: ");
                int usernum=int.Parse(Console.ReadLine());
                if (usernum == num)
                {
                    Console.WriteLine("Congratulations! You are win");
                    return;
                }
                else
                {
                    Console.WriteLine("You are loose");
                }
            }
            Console.WriteLine($"Sorry, you are fail. The number was {num}");
        }
    }
}
