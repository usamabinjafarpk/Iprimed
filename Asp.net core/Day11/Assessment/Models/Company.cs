using System.ComponentModel.DataAnnotations;

namespace Assessment.Models
{
    public class Company
    {
        [Required(ErrorMessage ="Enter Id")]
        public int CompanyId {  get; set; }
        [Required(ErrorMessage = "Enter Name")]

        public string Name { get; set;}
        [Required(ErrorMessage = "Enter City")]

        public string City { get; set;}
        [Required(ErrorMessage = "Enter Address")]
        public string Address { get; set;}
    }
}
