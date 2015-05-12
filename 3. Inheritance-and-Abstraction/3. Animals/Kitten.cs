using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Kitten : Cat
    {
        public double Weight { get; set; }

        public Kitten(string name, double age, string gender, string color, double weight) : base(name, age, gender, color)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = "f";
            this.Color = color;
            this.Weight = weight;
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Miiau");
        }
    }
}
