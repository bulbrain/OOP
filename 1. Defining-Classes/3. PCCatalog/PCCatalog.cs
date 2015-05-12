using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.PCCatalog
{
    class PCCatalog
    {
        public static void Main(string[] args)
        {
            Computer[] computerArray = new Computer[2];
            computerArray[0] = new Computer("Lenovo", new Component("Intel", 200), new Component("2GB", 50), new Component("Hitachi", 100));
            computerArray[1] = new Computer("Lenovo", new Component("Intel", 200));
            Array.Sort(computerArray, delegate(Computer x, Computer y) { return x.Price.CompareTo(y.Price); });
            foreach (var computer in computerArray)
            {
                computer.ReturnComputer();
            }
            Console.ReadLine();
        }
    }
}
