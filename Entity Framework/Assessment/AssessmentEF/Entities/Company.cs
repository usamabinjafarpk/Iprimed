using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AssessmentEF.Entities
{
    [Table("tbl_companies")]
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyId { get; set; }
        [Required] //set not null constraint
        [Column("Name", TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Required] //set not null constraint
        [Column("City", TypeName = "varchar")]
        [StringLength(30)]
        public string City { get; set; }
        [Required] //set not null constraint
        [Column("Address", TypeName = "varchar")]
        [StringLength(30)] 
        public string Address { get; set; }

    }
}
