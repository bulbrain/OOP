﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Galactic_GPS
{
    class Galactic_GPS
    {
        public static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
            Console.ReadLine();
        }
    }
}
