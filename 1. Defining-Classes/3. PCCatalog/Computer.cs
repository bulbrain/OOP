using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    class Computer
    {
        private string name;
        private double price;
        private Component Processor;
        private Component Ram;
        private Component Hdd;

        public Computer(string name, Component processor)
        {
            this.Name = name;
            this.Processor = processor;
            this.Price = price;
        }
        public Computer(string name, Component processor, Component ram, Component hdd)
        {
            this.Name = name;
            this.Processor = processor;
            this.Ram = ram;
            this.Hdd = hdd;
            this.Price = price;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name must be set.");
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
                value += Processor.Price;
                if (Ram != null)
                {
                    value += Ram.Price;
                }
                if (Hdd != null)
                {
                    value += Hdd.Price;
                }
                this.price = value;
            }
        }

        public void ReturnComputer()
        {
            string result = "Name: " + this.Name;
            if (!string.IsNullOrEmpty(this.Details))
            {
                result += ", details: " + this.Details;
            }
            result += "\n";
            result += "Processor: " + this.Processor;
            if (Ram != null)
            {
                result += "Ram: " + this.Ram;
            }
            if (Hdd != null)
            {
                result += "Hdd: " + this.Hdd;
            }
            result += "Total price: " + this.Price + " BGN";
            Console.WriteLine(result);
        }
    }

}
