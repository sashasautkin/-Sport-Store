
namespace Проект.Product
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    public class tablseBaket
    {
        [Key]
        public string UserName { get; set; }
        public float? Sum { get; set; }
        public virtual tableCustomer TableCustomer { get; set; }

    }
}
