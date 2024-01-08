using System.ComponentModel.DataAnnotations;

namespace Assessment.Models
{
    public class Student
    {
        [Required(ErrorMessage ="Enter Id")]
        public int StudentId { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set;}
        [Required(ErrorMessage = "Enter Qualification")]
        public string Qualification { get; set;}
        [Required(ErrorMessage = "Enter Skill")]
        public string Skill {  get; set;}
    }
}
