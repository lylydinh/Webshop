using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
<<<<<<< HEAD
        [Column (Order=1)]
        public int OrderID { set; get; }

        [Key]
        [Column(Order = 2)]
=======
        public int OrderID { set; get; }

        [Key]
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        public int ProductID { set; get; }

        public int Quantitty { set; get; }

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
    }
}