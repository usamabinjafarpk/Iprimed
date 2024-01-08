using Assessment.Models;

namespace Assessment.Repository
{
    public class StudentRepository : IStudentRepository
    {
        
        public List<Student> students = new List<Student>()
        {
            new Student(){StudentId=1,Name="Usama",Qualification="BTech",Skill=".net"}
        };
        public void DeleteStudent(int studentId)
        {
            foreach (var student in students)
            {
                if(student.StudentId == studentId)
                {
                    students.Remove(student);
                }
            }
        }

        public Student GetStudentById(int studentId)
        {
            foreach (var student in students)
            {
                if (student.StudentId == studentId)
                    return student;
            }
            return null;
        }

        public List<Student> GetStudents()
        {
            return students;
        }

        public List<Student> GetStudentsByQualification(string Qualification)
        {
            List<Student> result = new List<Student>();

            foreach (var student in students)
            {
                if(student.Qualification == Qualification)
                    result.Add(student);
            }
            return result;
        }

        public List<Student> GetStudentsBySkills(string skill)
        {
            List<Student> result = new List<Student>();
            foreach (var student in students)
            {
                if (skill.Equals(student.Skill))
                {
                    result.Add(student);
                }
            }
            return result;
        }

        public void InputStudent(Student student)
        {
            students.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            foreach(var item in students)
            {
                if(item.StudentId == student.StudentId)
                {
                    item.Qualification = student.Qualification;
                    item.Skill = student.Skill;
                }
            }
        }
    }
}
