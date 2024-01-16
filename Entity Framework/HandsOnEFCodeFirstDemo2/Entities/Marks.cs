using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirstDemo2.Entities
{
    [Table("tbl_marks")]
    public class Marks
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName ="varchar")]
        public string Exam {  get; set; }
        public int TotalMark {  get; set; }
        public int StudentId {  get; set; }

        //Navigation property
        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}
