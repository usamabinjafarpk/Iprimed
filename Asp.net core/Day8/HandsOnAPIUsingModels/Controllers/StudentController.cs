using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsOnAPIUsingModels.Models;
using System.Diagnostics.Eventing.Reader;
namespace HandsOnAPIUsingModels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>()
        {
            new Student{Id=123,Name="Usama",Age=22,Std=10},
            new Student{Id=223,Name="Akhil",Age=21,Std=9}

        };
        [HttpPost("AddStud")]
        public Student Add(Student student)
        {
            students.Add(student);
            return student;
        }

        [HttpGet,Route("GetAll")]
        public List<Student> GetStudents()
        {
            return students;
        }
        [HttpGet("GetStudById")]
        public Student GetStudent(int id)
        {
            foreach (var item in students)
            {
            if (item.Id == id) return item;
            }
            return null;
        }
        [HttpGet("GetStudByName")]
        public Student GetStudent(string name)
        {
            foreach (var item in students)
            {
                if(item.Name == name) return item;
            }
            return null;
        }
        [HttpDelete("DeleteStud/{id}")]
        public string DeleteStudent(int id)
        {
            try
            {
                Student student = null;
                foreach (var item in students)
                {
                    if (item.Id == id)
                    {
                        student = item;
                        break;
                    }
                }
                if (student != null)
                {
                    students.Remove(student);
                    return "Student is deleted";
                }
                else
                {
                    return "Invalid student id";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /* public string DeleteStudent(int id)
         {
             foreach (var item in students)
             {
                 if (!item.Id.Equals(id))
                 {
                     students.Remove(item);
                     return "Deleted";
                     break;
                 }
             }
             return "Invalid Student id";
         }*/

    }
}


