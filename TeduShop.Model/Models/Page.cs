using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

<<<<<<< HEAD
        [Column(TypeName = "varchar")]
=======
        [Column(TypeName = "varchar")]//chi ra chinh xac kieu du lieu 
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        [MaxLength(256)]
        [Required]
        public string Alias { set; get; }

        public string Content { set; get; }
    }
}