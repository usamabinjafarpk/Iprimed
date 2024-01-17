using HandsOnEFCodeFirstDemo2.Entities;
using HandsOnEFCodeFirstDemo2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnEFCodeFirstDemo2.Controllers
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
        [HttpGet,Route("GetStudents")]
        public IActionResult GetAll()
        {
            return Ok(studentRepository.GetAll());
        }
        [HttpGet,Route("GetStudent/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(studentRepository.Get(id));
        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add(Student student)
        {
            studentRepository.Add(student);
            return Ok(student);
        }
        [HttpPut,Route("EditStudent")]
        public IActionResult Update(Student student)
        {
            studentRepository.Update(student);
            return Ok(student);
        }
        [HttpDelete, Route("DeleteStudent/{id}")]
        public IActionResult Delete(int id)
        {
            studentRepository.Delete(id);
            return Ok("Student Deleted");
        }
    }
}
