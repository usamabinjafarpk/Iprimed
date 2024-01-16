using HandsOnAPIWithEFCodeFirstDemo1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace HandsOnAPIWithEFCodeFirstDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly MyContext _context;
        public StudentController()
        {

            _context = new MyContext();

        }
        [HttpPost,Route("AddStudent")]
        public IActionResult Add([FromBody]Student student)
        {
            try
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("GetAll")]
        public IActionResult Edit()
        {
            try
            {
                List<Student> students = _context.Students.ToList();
                return Ok(students);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet,Route("Get/{id}")]
        public IActionResult GetAction(int id)
        {
            try
            {
                Student student = _context.Students.SingleOrDefault(s => s.Id == id);
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut,Route("EditStudent")]
        public IActionResult EditStud(Student student)
        {
            try
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return Ok(student);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                Student student = _context.Students.Find(id);
                _context.Students.Remove(student);
                _context.SaveChanges();
                return Ok(new JsonResult("Student deleted successfully", student));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
