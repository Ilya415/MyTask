using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTask.Models.Entities
{
    public class Shop
    {
        public int ShopId{ get; set; }
        public string ShopName { get; set; }
        public string ShopAdress { get; set; }
        public string ShopWorkingTime { get; set; }
    }
}