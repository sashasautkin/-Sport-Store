﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Проект.Product
{
   public  class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {
        }
    }
}
