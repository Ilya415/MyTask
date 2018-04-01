using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyTask.Models.Repository;

namespace MyTask.Models.Unit_of_work
{
    public class UnitOfWork : IDisposable
    {
        private ShopAndProductContext db = new ShopAndProductContext();
        private ShopRepository shopRepository;
        private ProductRepository productRepository;
        private ShopAndProductDepRepository shopAndProductDepRepository;
        private bool disposed = false;

        public ShopRepository Shops
        {
            get
            {
                if (shopRepository == null)
                    shopRepository = new ShopRepository(db);
                return shopRepository;
            }
        }

        public ProductRepository Products
        {
            get
            {
                if (productRepository == null)
                    productRepository = new ProductRepository(db);
                return productRepository;
            }
        }
        public ShopAndProductDepRepository ShopsAndProdutsDep
        {
            get
            {
                if (shopAndProductDepRepository == null)
                    shopAndProductDepRepository = new ShopAndProductDepRepository(db);
                return shopAndProductDepRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}