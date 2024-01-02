using System.Xml.Linq;

namespace CodeChallenge1
{
    class Student
    {
        public int id;
        public string name;
        public int age;
        public byte std;
        public char section;
    }
    class StudentRepository
    {
        public Student[] students = new Student[5];
        public int idx = 0;
        public void CreateStud(Student student)
        {
            if (idx <= students.Length)
            {
                students[idx] = student;
                idx++;
            }
            else
            {
                Console.WriteLine("Student is full");
            }
        }

       
        public Student[] GetStudById(int id)
        {
            Student[] std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.id == id)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetStudByName(string name)
        {
            Student[] std=new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.name == name)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetStudByStd(byte std)
        {
            Student[] std1 = new Student[students.Length]; 
            int idx= 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.std == std)
                    {
                        std1[idx] = student;
                        idx++;
                    }
                }
            }
            return std1;
        }
        public Student[] GetStudByStdAndSection(int  std, char section)
        {
            Student[] std1 = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.std == std && student.section == section)
                    {
                        std1[idx] = student;
                        idx++;
                    }
                }
            }
            return std1;
        }
        public void Updatestud(Student student)
        {
            for(int i=0; i < students.Length; i++)
            {
                if (student != null) { 
                if (students[i].id == student.id)
                {
                    students[i].name = student.name;
                    students[i].age = student.age;
                    
                }
                }
            }
        }
        public Student[] GetStudByAge(int age)
        {
            Student[] std = new Student[students.Length];
            int idx = 0;
            foreach (Student student in students)
            {
                if (student != null)
                {
                    if (student.age == age)
                    {
                        std[idx] = student;
                        idx++;
                    }
                }
            }
            return std;
        }
        public Student[] GetAllStud()
        {
            return students;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentRepository studentRepository = new StudentRepository();
            do
            {
                Console.WriteLine("1.Create Student");
                Console.WriteLine("2.Update Student");
                Console.WriteLine("3.Display student details based on ID");
                Console.WriteLine("4.Display student details based on Name");
                Console.WriteLine("5.Display all students based on std");
                Console.WriteLine("6.Display all students based on std and section");
                Console.WriteLine("7.Display all students based on age.");
                Console.WriteLine("8.Display all students details.");
                Console.WriteLine("9.Exit");
                int ch=int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter Student Id:");
                            student.id = int.Parse(Console.ReadLine()); ;
                            Console.WriteLine("Enter the name:");
                            student.name = Console.ReadLine();
                            Console.WriteLine("Enter the age:");
                            student.age=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the standard:");
                            student.std=byte.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the section:");
                            student.section=char.Parse(Console.ReadLine());
                            studentRepository.CreateStud(student);
                        }
                        break;
                    case 2:
                        {
                            Student student=new Student();
                            Console.WriteLine("Enter id:");
                            student.id=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the name:");
                            student.name = Console.ReadLine();
                            Console.WriteLine("Enter the age:");
                            student.age = int.Parse(Console.ReadLine());
                            studentRepository.Updatestud(student);
                        }
                        break;
                   
                    case 3:
                        {
                            Console.WriteLine("Enter the student Id:");
                            int id=int.Parse(Console.ReadLine());
                            Student[] student = studentRepository.GetStudById(id);
                            foreach(Student students in student)
                            {
                                if (students != null)
                                {
                                    Console.WriteLine($"Student Id:{students.id} Name:{students.name} Age:{students.age} Std:{students.std} Section:{students.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter the Student Name:");
                            string name=Console.ReadLine();
                            Student[] students = studentRepository.GetStudByName(name);
                            foreach(Student s in students)
                            {
                                if(s != null)
                                {
                                    Console.WriteLine($"Student Id:{s.id} Name:{s.name} Age:{s.age} Std:{s.std} Section:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter the standard:");
                            byte std=byte.Parse(Console.ReadLine());
                            Student[] students = studentRepository.GetStudByStd(std);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"Student Id:{s.id} Name:{s.name} Age:{s.age} Std:{s.std} Section:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Enter the Std:");
                            int std=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Section:");
                            char section=char.Parse(Console.ReadLine());
                            Student[] students = studentRepository.GetStudByStdAndSection(std,section);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"Student Id:{s.id} Name:{s.name} Age:{s.age} Std:{s.std} Section:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Enter Age:");
                            int age=int.Parse(Console.ReadLine());
                            Student[] students = studentRepository.GetStudByAge(age);
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"Student Id:{s.id} Name:{s.name} Age:{s.age} Std:{s.std} Section:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 8:
                        {
                            Student[] students = studentRepository.GetAllStud();
                            foreach (Student s in students)
                            {
                                if (s != null)
                                {
                                    Console.WriteLine($"Student Id:{s.id} Name:{s.name} Age:{s.age} Std:{s.std} Section:{s.section}");
                                    Console.WriteLine();
                                }
                            }
                        }
                        break;
                    case 9:
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        Console.WriteLine("Enter a valid option...");
                        Console.WriteLine();
                        break;
                }
            }while (true);
        }
    }
}
