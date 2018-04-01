using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MyTask.Models.Entities;

namespace MyTask.Models.Repository
{
    public class ShopAndProductContext:DbContext
    {
        public ShopAndProductContext()
        {
          
        }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopAndProductDep> ShopsAndProductsDep { get; set; }
    }
}