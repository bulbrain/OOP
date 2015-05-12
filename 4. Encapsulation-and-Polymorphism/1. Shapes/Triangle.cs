using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Triangle : BasicShape
    {
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        public override double CalculateArea()
        {
            double result = (this.Width * this.Height) / 2;
            return result;
        }
        public override double CalculatePerimeter()
        {
            double result = 2 * Math.Sqrt(Math.Pow((this.Width / 2), 2) + Math.Pow(this.Height, 2)) + this.Width;
            return result;
        }
    }
}
