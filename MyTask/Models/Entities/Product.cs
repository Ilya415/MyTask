using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyTask.Models.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductAbout { get; set; }
    }
}