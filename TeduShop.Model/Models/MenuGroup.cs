<<<<<<< HEAD
﻿using System.Collections.Generic;
=======
﻿using System.Collections;
using System.Collections.Generic;
>>>>>>> 279c44cd93d483a7ab817450997baa84cb9eadf8
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Name { set; get; }

        public virtual IEnumerable<Menu> Menus { set; get; }
    }
}