using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MyTask.Models.Entities;

namespace MyTask.Models.Repository
{
    public class ShopAndProductDepRepository : IDepRepository<ShopAndProductDep>
    {
        private ShopAndProductContext db;

        public ShopAndProductDepRepository(ShopAndProductContext context)
        {
            this.db = context;
        }
        public void Create(ShopAndProductDep item)
        {
            this.db.ShopsAndProductsDep.Add(item);
        }

        public void Delete(int id)
        {
            ShopAndProductDep temp = this.db.ShopsAndProductsDep.Find(id);
            if (temp != null)
                this.db.ShopsAndProductsDep.Remove(temp);
        }

        public ShopAndProductDep Get(int id)
        {
            return this.db.ShopsAndProductsDep.Find(id);
        }
        public IEnumerable<ShopAndProductDep> GetAll()
        {
           return  this.db.ShopsAndProductsDep;
        }

        public IEnumerable<ShopAndProductDep> GetDep(int id)
        {
            return this.db.ShopsAndProductsDep.Where(p => p.ShopId == id);
        }

        public void Update(ShopAndProductDep item)
        {
            this.db.Entry(item).State = EntityState.Modified;
        }
    }
}