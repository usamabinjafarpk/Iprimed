using AssessmentEF.Entities;

namespace AssessmentEF.Repositories
{
    public interface IStudentRepository
    {
        void Add(Student student);
        List<Student> GetStudentByQualification(string qualification);
        List<Student> GetStudentBySkill(string skill);
        Student GetStudentById(int id, string name);
        void Update(Student student);
        void Delete(int id);
    }
}
