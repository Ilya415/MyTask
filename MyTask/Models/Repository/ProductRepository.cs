using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyTask.Models.Entities;

namespace MyTask.Models.Repository
{
    public class ProductRepository : IRepository<Product>
    {
        private ShopAndProductContext db;

        public ProductRepository(ShopAndProductContext context)
        {
            this.db = context;
        }
        public void Create(Product item)
        {
            this.db.Products.Add(item);
        }

        public void Delete(int id)
        {
            Product prod = this.db.Products.Find(id);
            if (prod != null)
                this.db.Products.Remove(prod);
        }

        public Product Get(int id)
        {
            return this.db.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return this.db.Products;
        }

        public void Update(Product item)
        {
            this.db.Entry(item).State = EntityState.Modified;
        }
    }
}