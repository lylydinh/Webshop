using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
<<<<<<< HEAD
=======
using System.Xml.Linq;
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
<<<<<<< HEAD
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

=======
        [MaxLength(256)]
        public string Alias { set; get; }

        [Required]
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        public int CategoryID { set; get; }

        [MaxLength(256)]
        public string Image { set; get; }

<<<<<<< HEAD
        [Column(TypeName = "xml")]
        public string MoreImages { set; get; }

        public decimal Price { set; get; }
=======
        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }

>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        public decimal? PromotionPrice { set; get; }
        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }
<<<<<<< HEAD

        public string Content { set; get; }
=======
        public string Content { set; get; }

>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
<<<<<<< HEAD
        public virtual ProductCategory ProductCategories { set; get; }
=======
        public virtual ProductCategory ProductCategory { set; get; }
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
    }
}