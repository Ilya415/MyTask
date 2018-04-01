using MyTask.Models.Entities;
using MyTask.Models.Unit_of_work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTask.Controllers
{
    public class ShopController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: Shops
        public ActionResult Index()
        {
            return View("Index", unitOfWork.Shops.GetAll());
        }

        // GET: Shops/Details/5
        public ActionResult Update(int value)
        {
            IEnumerable<ShopAndProductDep> temp = this.unitOfWork.ShopsAndProdutsDep.GetDep(value);
            List<Product> tempProd = new List<Product>();
            foreach (ShopAndProductDep record in temp)
            {
                tempProd.Add(this.unitOfWork.Products.Get(record.ProductId));
            }
            if (Request.IsAjaxRequest())
            {
                return PartialView("UpdateUpp", tempProd);
            }
            return View("UpdateUpp", value);
        }

    }
}
