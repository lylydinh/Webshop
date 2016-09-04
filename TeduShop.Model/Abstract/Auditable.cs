using System;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
<<<<<<< HEAD
    /// <summary>
    /// Maxlength gioi han kich thuoc cua chuoi hoac so
    /// </summary>
=======
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
    public abstract class Auditable : IAuditable
    {
        public DateTime? CreatedDate { set; get; }

        [MaxLength(256)]
        public string CreatedBy { set; get; }

        public DateTime? UpdatedDate { set; get; }

        [MaxLength(256)]
        public string UpdatedBy { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }
<<<<<<< HEAD
=======

>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        public bool Status { set; get; }
    }
}