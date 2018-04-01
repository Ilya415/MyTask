using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyTask.Models.Unit_of_work;
using MyTask.Models.Entities;

namespace MyTask.Controllers
{
    public class ProductController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork();

        public IEnumerable<Product> Get()
        {
            return this.unitOfWork.Products.GetAll();

        }

        // GET: api/Shop/5
        public IEnumerable<Product> Get(int id)
        {
            IEnumerable<ShopAndProductDep> temp = this.unitOfWork.ShopsAndProdutsDep.GetDep(id);
            List<Product> tempProd = new List<Product>();
            foreach (ShopAndProductDep record in temp)
            {
                tempProd.Add(unitOfWork.Products.Get(record.ProductId));
            }
            return tempProd;
        }
    }
}
