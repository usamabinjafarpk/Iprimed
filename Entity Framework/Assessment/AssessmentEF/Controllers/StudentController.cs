using AssessmentEF.Entities;
using AssessmentEF.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private StudentRepository studentRepository;

        public StudentController(StudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpPost,Route("AddStudents")]
        public IActionResult AddStudents(Student student)
        {
            try
            {
                studentRepository.Add(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetStudentByIdOrName")]
        public IActionResult GetStudentById(int id,string name)
        {
            try
            {
                return Ok(studentRepository.GetStudentById(id, name));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetStudentByQualification")]
        public IActionResult GetStudentByQualification(string qualification)
        {
            try
            {
                return Ok(studentRepository.GetStudentByQualification(qualification));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetStudentBySkill")]
        public IActionResult GetStudentBySkill(string skill)
        {
            try
            {
                return Ok(studentRepository.GetStudentBySkill(skill));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("UpdateStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            try
            {
                studentRepository.Update(student);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("DeleteStudent")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
                studentRepository.Delete(id);
                return Ok("Student deleted successfully");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
