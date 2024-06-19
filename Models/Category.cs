using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MinLength(3)] // não existe essa validacao direto pelo banco, mas podemos fazer com data annotations
        [MaxLength(80)]
        [Column("Name", TypeName="NVARCHAR")]
        public string Name { get; set; }

        [Required]
        [MaxLength(80)]
        [Column("Slug", TypeName="VARCHAR")]
        public string Slug { get; set; }
    }
}