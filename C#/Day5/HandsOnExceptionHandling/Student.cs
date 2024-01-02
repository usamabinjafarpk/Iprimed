using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptionHandling
{
    class AgeException : Exception
    {
        
        string message;
        public AgeException(int age)
        {
            message = $"{age} is not applicable for applying this exam";
        }
        public override string Message
        {
            get { return message; }
        }
        public string Msg
        {
            get { return message; }
        }
    }
    internal class Student
    {
        public void ApplyExam(int age)
        {
                try
                {
                    if(age>=12 && age <= 15)
                    {
                        Console.WriteLine("Applied for exam successfully");
                    }
                    else
                    {
                        throw new AgeException(age);
                    }
                }
                catch(AgeException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine(ex.Msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    class Test_Student
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the age:");
                int age = int.Parse(Console.ReadLine());
                Student sd=new Student();
                sd.ApplyExam(age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
