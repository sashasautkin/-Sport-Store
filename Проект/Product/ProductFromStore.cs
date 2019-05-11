using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Product
{
   public class ProductFromStore
    {
        public string UserName { get; set; }
        [Key]
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Id { get; set; }
        public virtual tableUser TableUser { get; set; }
        public virtual tableCustomer TableCustomer { get; set; }


    }


}

