namespace HandsOnConstructorsAndProperties
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string school;
        public static string city;

        static Student()
        {
            city = "TVM";
        }
        public Student() {
            school = "ABC";
        }
        public Student(string fname, string lname, string s)
        {
            firstName = fname;
            lastName = lname;
            school = s;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{firstName} {lastName} School:{school} City:{city}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student s = new Student();
            s.firstName = "Usama";
            s.lastName = "Jafar";
            s.Display();
            Student s1 = new Student("abc","qwe","kwe");
            s1.Display();
        }
    }
}
