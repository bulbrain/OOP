using System;

namespace _1.SquareRoot
{
    class SquareRoot
    {

        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            try
            {
                int num = Int32.Parse(n);
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
            Console.ReadLine();
        }
    }
}
