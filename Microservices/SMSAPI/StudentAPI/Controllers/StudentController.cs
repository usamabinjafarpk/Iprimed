using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;
using StudentAPI.Repositories;

namespace StudentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            try
            {
                return Ok(_studentRepository.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetStudentsById/{id}")]
        public IActionResult GetStudentsById(int id)
        {
            try
            {
                return Ok(_studentRepository.GetStudent(id));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetStudents/{std}")]
        public IActionResult GetStudentsByStd(string std)
        {
            try
            {
                return Ok(_studentRepository.GetAllStudents(std));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("GetStudents/{std}/{section}")]
        public IActionResult GetStudentsByStdAndSection(string std,string section)
        {
            try
            {
                return Ok(_studentRepository.GetAllStudents(std,section));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("AddStudent")]
        public IActionResult AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
            return Ok(student);
        }
        [HttpPut("EditStudent")]
        public IActionResult UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
            return Ok(student);
        }
    }
}
