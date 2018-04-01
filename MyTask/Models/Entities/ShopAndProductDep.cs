using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTask.Models.Entities
{
    public class ShopAndProductDep
    {
        public int Id { get; set; }
        public int ShopId { get; set; }
        public int ProductId { get; set; }
    }
}