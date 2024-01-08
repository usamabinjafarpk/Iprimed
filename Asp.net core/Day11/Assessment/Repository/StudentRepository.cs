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
            try
            {
                foreach (var student in students)
                {
                    if (student.StudentId == studentId)
                    {
                        students.Remove(student);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetStudentById(int studentId)
        {
            try
            {
                foreach (var student in students)
                {
                    if (student.StudentId == studentId)
                        return student;
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudents()
        {
            try
            {
                return students;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentsByQualification(string Qualification)
        {
            try
            {
                List<Student> result = new List<Student>();

                foreach (var student in students)
                {
                    if (student.Qualification == Qualification)
                        result.Add(student);
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Student> GetStudentsBySkills(string skill)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        public void InputStudent(Student student)
        {
            try
            {
                students.Add(student);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateStudent(Student student)
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.StudentId == student.StudentId)
                    {
                        item.Qualification = student.Qualification;
                        item.Skill = student.Skill;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
