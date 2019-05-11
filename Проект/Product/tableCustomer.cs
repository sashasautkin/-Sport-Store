using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Проект.Product
{
   public class tableCustomer
    {
        public string UserName { get; set; } 
        [Key]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public virtual ProductFromStore ProductFromStore { get; set; }
        public virtual tablseBaket TablseBaket { get; set; }
    }
}
