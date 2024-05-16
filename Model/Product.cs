using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeShopManagement
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProductType { get; set; }
        public int Stock { get; set; }
        public double price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }

        public Product() { }

        public Product(string id, string name, string productType, int stock, double price, string image)
        {
            Id = id;
            Name = name;
            ProductType = productType;
            Stock = stock;
            this.price = price;
            Image = image;
        }
    }
}
