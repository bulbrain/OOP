using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StringBuilder_Extensions
{
    class StringBuilderExt
    {
        public static void Main()
        {
            StringBuilder test1 = new StringBuilder("Pesho");
            Console.WriteLine(test1.Substring(1, 4));
            /// Console.WriteLine(test1.Substring(1, 5)); Arguments out of range exeption
            Console.WriteLine(test1.RemoveText("esh"));
            StringBuilder test2 = new StringBuilder("Pesho");
            Console.WriteLine(test2.AppendAll("asd"));
            Console.ReadLine();
        }
    }
}
