using System;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }
<<<<<<< HEAD
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; } 
=======

        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }

>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
        bool Status { set; get; }
    }
}