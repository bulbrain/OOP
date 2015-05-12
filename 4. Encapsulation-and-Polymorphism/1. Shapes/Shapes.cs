using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    class Shapes
    {
        static void Main(string[] args)
        {
            BasicShape[] shapes = new BasicShape[3];
            shapes[0] = new Triangle(20, 30);
            shapes[1] = new Rectangle(10, 20);
            shapes[2] = new Circle(10);
            foreach (var f in shapes)
            {
                Console.WriteLine(f.CalculateArea() + " " + f.CalculatePerimeter());
            }
            Console.ReadLine();
        }
    }
}
