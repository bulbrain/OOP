using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Customer
{
    class Payment
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Payment(string productName, decimal price)
        {
            this.Price = price;
            this.ProductName = productName;
        }

        public override string ToString()
        {
            return "Product: " + this.ProductName + ", price: " + this.Price;
        }
    }
}
