using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace HandsOnEFCodeFirstDemo2.Entities
{
    [Table("tbl_students")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [Required]
        [Column("Name",TypeName ="varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        [Column("Class", TypeName = "varchar")]
        [StringLength(30)]
        public string Std { get; set; }
        [Column(TypeName ="char")]
        [StringLength(2)]
        public string Section { get; set; }

    }
}
