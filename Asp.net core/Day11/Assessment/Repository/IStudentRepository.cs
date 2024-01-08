using Assessment.Models;
using System;

namespace Assessment.Repository
{
    public interface IStudentRepository
    {
 


        void InputStudent(Student student);
        List<Student> GetStudents();
        List<Student> GetStudentsBySkills(string skill);
        List<Student> GetStudentsByQualification(string Qualification);

        Student GetStudentById(int studentId);
        void UpdateStudent(Student student);
        void DeleteStudent(int studentId);

    }
}
