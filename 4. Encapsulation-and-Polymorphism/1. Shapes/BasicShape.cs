﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    public abstract class BasicShape : IShape 
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
