namespace HandsOnClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.id = 1;
            obj.name = "Usama";
            obj.gender = 'M';
            obj.age = 22;

            obj.Display();
            Console.WriteLine();
            Student s= new Student();
            s.id = 2;
            s.name = "Njyaan";
            s.gender = 'M';
            s.age = 22;

            s.Display();
            Student s1 = new Student() { id=23, name="usa", age=22, gender='M'};
            s1.Display();

            //Student s2 = null;
            //s2.id = 3;
            //s2.name = "blah";
            //s2.Display();

            Student[] students = new Student[3] ;
            students[0] = new Student()
            {
                id= 1,
                name="abc",
                age=22,
                gender='M'
            };
            students[1] = new Student()
            {
                id = 2,
                name = "abcd",
                age = 22,
                gender = 'F'
            };
            students[2] = new Student()
            {
                id = 3,
                name = "abcdrf",
                age = 22,
                gender = 'M'
            };
            Console.WriteLine();
            students[0].Display();
            Console.WriteLine();
            foreach(Student std in students)
            {
                std.Display();
            }
            Console.WriteLine();
            for(int i=0; i<students.Length; i++)
            {
                students[i].Display();
            }
        }
    }
}
