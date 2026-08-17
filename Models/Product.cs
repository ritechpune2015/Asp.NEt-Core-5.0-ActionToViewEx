using System;

namespace ActionToViewEx.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        public string ProductName { get; set; }
        public string MfgName { get; set; }
        public decimal Price { get; set; }

        public Product()
        {
            this.ProductID = 123;
            this.ProductName = "Mouse";
            this.MfgName = "Logitech";
            this.Price = 5500;
        }
    }
}
