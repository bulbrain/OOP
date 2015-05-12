using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Bank_of_Kurtovo_Konare
{
    class Program
    {
        static void Main(string[] args)
        {
            Deposit test1 = new Deposit(Customer.Individual, 122m, 3.4m);
            Console.WriteLine(test1.Balance);
            Console.ReadLine();
        }
    }
}
