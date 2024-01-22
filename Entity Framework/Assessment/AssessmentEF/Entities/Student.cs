using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AssessmentEF.Entities
{
    [Table("tbl_students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }
        [Required] //set not null constraint
        [Column("Name", TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required] //set not null constraint
        [Column("Qualification", TypeName = "varchar")]
        [StringLength(30)]
        public string Qualification { get; set; }
        [Required] //set not null constraint
        [Column("Skill", TypeName = "varchar")]
        [StringLength(30)]
        public string Skill { get; set;}

    }
}
