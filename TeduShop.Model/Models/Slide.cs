using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength(256)]
<<<<<<< HEAD
        public string Image { set; get; }

        [MaxLength(256)]
        public string Description { set; get; }
=======
        public string Description { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8

        [MaxLength(256)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }
    }
}