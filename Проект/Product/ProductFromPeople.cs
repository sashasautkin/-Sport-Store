using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Product
{
   public class ProductFromPeople 
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 2)]
        public double Price { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Id { get; set; }

        public virtual ProductFromStore ProductFromStore { get; set; }

        public virtual tableUser TableUser { get; set; }



    }
}
