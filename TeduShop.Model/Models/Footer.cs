using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
<<<<<<< HEAD
    /// <summary>
    /// Name :Table:gen code ten table chinh la ten trong ngoac nhon
    /// Key ghi chu truong nay la khoa chinh
    /// required :ghi chú trường này là không thể bỏ trống
    /// </summary>
=======
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [Required]
        public string Content { set; get; }
    }
}