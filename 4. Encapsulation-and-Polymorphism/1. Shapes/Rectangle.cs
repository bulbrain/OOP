using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            double result = this.Width * this.Height;
            return result;
        }

        public override double CalculatePerimeter()
        {
            double result = this.Width * 2 + this.Height * 2;
            return result;
        }
    }
}
