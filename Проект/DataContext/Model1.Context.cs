﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Проект.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LoginDBEntities : DbContext
    {
        public LoginDBEntities()
            : base("name=LoginDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ProductFromPeople> ProductFromPeoples { get; set; }
        public virtual DbSet<ProductFromStore> ProductFromStores { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tableBasket> tableBaskets { get; set; }
        public virtual DbSet<tableCustomer> tableCustomers { get; set; }
        public virtual DbSet<tableUser> tableUsers { get; set; }
    }
}
