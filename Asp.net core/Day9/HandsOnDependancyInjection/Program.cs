namespace HandsOnDependancyInjection
{
    class Student
    {
        public int Id;
        public string Name;

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    class Register
    {
        Student student;

        public Register(Student student)
        {
            this.student = student;
        }
        public void Details()
        {
            Console.WriteLine($"Id:{student.Id} Name:{student.Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Register register=new Register(new Student(23,"Usama"));
            register.Details();
        }
    }
}
