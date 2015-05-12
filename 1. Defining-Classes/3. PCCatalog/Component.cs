using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    class Component
    {
        private string name;
        private string details;
        private double price;

        public Component(string name, double price, string details = null)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name must be set.");
                }
                this.name = value;
            }
        }
        public string Details { get; set; }
        public double Price
        {
            get { return this.price; }
            set
            {
                if ((this.price < 0) || double.IsNaN(value))
                {
                    throw new ArgumentOutOfRangeException("Price must be set and > 0");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            string result = this.Name + ", price: " + this.Price + " BGN";
            if(!string.IsNullOrEmpty(this.Details))
            {
                result += "details: " + this.Details;
            }
            return result + "\n";
        }
    }
}
