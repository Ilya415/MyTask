using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTask.Models.Entities;
using System.Data.Entity;

namespace MyTask.Models.Repository
{
    public class ShopRepository : IRepository<Shop>
    {
        private ShopAndProductContext db;

        public ShopRepository(ShopAndProductContext context)
        {
            this.db = context;
        }
        public void Create(Shop item)
        {
            this.db.Shops.Add(item);
        }

        public void Delete(int id)
        {
            Shop shop = this.db.Shops.Find(id);
            if (shop != null)
                this.db.Shops.Remove(shop);
        }

        public Shop Get(int id)
        {
            return this.db.Shops.Find(id);
        }

        public IEnumerable<Shop> GetAll()
        {
            return this.db.Shops;
        }

        public void Update(Shop item)
        {
            this.db.Entry(item).State = EntityState.Modified;
        }
    }
}