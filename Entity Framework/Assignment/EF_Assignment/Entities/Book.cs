using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EF_Assignment.Entities
{
    [Table("tbl_book")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BookId { get; set; }
        [Required]
        [Column("BookName", TypeName = "varchar")]
        [StringLength(30)]
        public string BookName { get; set; }
        [Required]
        public int Price {  get; set; }
        [Required]
        [Column("Author", TypeName = "varchar")]
        [StringLength(30)]
        public string Author {  get; set; }
        [Required]
        [Column("Language", TypeName = "varchar")]
        [StringLength(30)]
        public string Lang { get; set; }
        [Required]
        public DateTime ReleaseDate {  get; set; }
    }
}
