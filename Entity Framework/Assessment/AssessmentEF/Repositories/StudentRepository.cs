using AssessmentEF.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AssessmentEF.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyContext _context;

        public StudentRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public Student GetStudentById(int id, string name)
        {
            
            return _context.Students.Where(i=>i.StudentId==id && i.Name==name).FirstOrDefault();

        }

        public List<Student> GetStudentByQualification(string qualification)
        {
            return _context.Students.Where(q=>q.Qualification==qualification).ToList();
        }

        public List<Student> GetStudentBySkill(string skill)
        {
            return _context.Students.Where(s=>s.Skill==skill).ToList();
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
    }
}
