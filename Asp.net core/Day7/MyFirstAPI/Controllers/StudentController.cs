using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        string[] students = new string[] { "asd", "sdf", "dfg" };
        [HttpGet("AllStud")]
        public string[] GetStudents()
        {
            return students;
        }
        [HttpGet("GetId/{id}")]
        public string GetStudent(int id) {
        return students[id-1];
        }
        [HttpPost("Addstud/{name}")]
        public string Add(string name)
        {
            students[0] = name;
            return "Added";
        }
        [HttpPut("Update/{name}")]
        public string Update(string name)
        {
            return "Student updated";
        }
        [HttpDelete("delete/{id}")]
        public string Delete(int id)
        {
            return "Deleted";
        }
    }
}
