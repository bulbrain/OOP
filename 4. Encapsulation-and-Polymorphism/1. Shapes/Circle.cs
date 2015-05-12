using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Circle : BasicShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public override double CalculateArea()
        {
            double result = this.Radius * Math.PI;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = this.Radius * Math.PI * Math.PI;
            return result;
        }
    }
}
