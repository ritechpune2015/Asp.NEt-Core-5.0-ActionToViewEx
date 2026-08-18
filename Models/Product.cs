using System;
using System.Collections.Generic;

namespace ActionToViewEx.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> lst = new List<Product>() { 
              new Product() {ProductID=1,ProductName="Mouse",MfgName="Intex",Price=450}
            };

            return lst;
        }
    }
}
