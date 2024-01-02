using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet("Greet")]
        public string Greet()
        {
            return "Good morning teacher";
        }
        [HttpGet]
        public string[] GetTchr()
        {
            return new string[] { "abc", "bcd", "cde" };
        }
        [HttpGet("Hello")]
        public string Hello() {

            return "Heloooooo"+Greet();

        }
        [HttpGet("GetAll/{std}")]
        public string[] GetStrings(string std)
        {
            string a = std;

            return new string[] { std, a ,"abc", "bcd", "cde" };
        }
    }
}
