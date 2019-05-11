using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Проект.Product
{
  public  class tableUser 
    {
        [Key]
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set;  }
        public virtual ICollection<ProductFromPeople> ProductFromPeoples { get; set; }
        public virtual ICollection<ProductFromStore> ProductFromStores { get; set; }
    }
}
