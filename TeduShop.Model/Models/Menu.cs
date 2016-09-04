using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
<<<<<<< HEAD
    /// <summary>
    ///  int? cho phep null
    /// </summary>
=======
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
    [Table("Menus")]
    public class Menu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        [Required]
        [MaxLength(256)]
        public string URL { set; get; }

<<<<<<< HEAD
        [Required]
        public int GroupID { set; get; }

        [Required]
        public bool Status { set; get; }

        public int? DisplayOrder { set; get; }
        public string Target { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }
=======
        public int? DisplayOrder { set; get; }

        [Required]
        public int GroupID { set; get; }

        [ForeignKey("GroupID")]
        public virtual MenuGroup MenuGroup { set; get; }

        [MaxLength(10)]
        public string Target { set; get; }

        public bool Status { set; get; }
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
    }
}