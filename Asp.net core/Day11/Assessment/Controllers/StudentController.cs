using Assessment.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assessment.Models;
using System.Xml.Linq;

namespace Assessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        [HttpPost("InputStudent")]
        public IActionResult InputStudent(Student student)
        {
            if(ModelState.IsValid)
            {
                studentRepository.InputStudent(student);
                return Ok(student);
            }
            else { return BadRequest(); }
            
        }
        [HttpGet("GetStudentsByQualification/{qualification}")]
        public IActionResult GetStudentsByQualification(string qualification)
        {
            return StatusCode(200, studentRepository.GetStudentsByQualification(qualification));

        }
        [HttpGet("GetAllStudents")]
        public IActionResult GetStudents()
        {
            List<Student> students =studentRepository.GetStudents();
            return Ok(students);

        }
        [HttpGet("GetStudentById/{StudentId}")]
        //Movie movie = movieRepository.GetMoviesByName(name);
        public IActionResult GetStudentById(int StudentId)
        {
            Student student=studentRepository.GetStudentById(StudentId);
            return Ok(student);
        }
        [HttpGet("GetStudentsBySkills/{skill}")]
        public IActionResult GetStudentsBySkills(string skill)
        {
            return StatusCode(200,studentRepository.GetStudentsBySkills(skill));
        }
        [HttpPut("UpdateStudent/{id}")]
        public IActionResult UpdateStudent(Student student)
        {
            studentRepository.UpdateStudent(student);
            return Ok(student);
        }
        [HttpDelete("DeleteStudent")]
        public void DeleteStudent(int StudentId)
        {
            studentRepository.DeleteStudent(StudentId);
        }
    }
}
