using System.ComponentModel.DataAnnotations;

namespace Assignment.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        [Required(ErrorMessage ="Enter movie name")]
        public string MovieName { get; set; }
        [Required(ErrorMessage = "Enter movie language")]
        public string Lang { get; set;}
        [Required(ErrorMessage = "Enter movie release year")]
        public int ReleaseYear {  get; set; }
        [Required(ErrorMessage = "Enter actor name")]
        public string Actor { get; set; }
        [Required(ErrorMessage = "Enter director name")]
        public string Director { get; set; }

    }
}
