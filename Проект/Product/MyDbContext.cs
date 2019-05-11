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
   public  class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }
        public DbSet<tableUser> TableUsers { get; set; }
        public DbSet<ProductFromPeople> ProductFromPeoples { get; set; }
        public DbSet<ProductFromStore> ProductFromStores { get; set; }
        public DbSet<tableCustomer> TableCustomers { get; set; }
        public DbSet<tablseBaket> TablseBakets { get;set; }



    }

}
