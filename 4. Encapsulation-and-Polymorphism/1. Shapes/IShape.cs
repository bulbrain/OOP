using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    interface IShape
    {
        double Width { get; set; }
        double Height { get; set; }

        double CalculateArea();
        double CalculatePerimeter();
    }
}
