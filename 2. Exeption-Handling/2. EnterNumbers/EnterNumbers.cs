using System;

namespace _2.EnterNumbers
{
    class EnterNumbers
    {

        static void Main(string[] args)
        {
            int start = 0;
            int end = 100;

            Console.WriteLine("Insert the start:");
            try
            {
                start = Int32.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine("Insert the end:");
            try
            {
                end = Int32.Parse(Console.ReadLine());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid number");
            }
            ReadNumbers(start, end);
        }

        public static void ReadNumbers(int start, int end)
        {
            int[] numbers = new int[10];
            Console.WriteLine("Insert 10 numbers between {0} and {1}", start, end);
            for (int i = 0; i < 10; i++)
            {
                    numbers[i] = Int32.Parse(Console.ReadLine());
                    if (numbers[i] < start || numbers[i] > end)
                    {
                        Console.WriteLine("Invalid number. Try again");
                        i--;
                    }
            }
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.ReadLine();
        }
    }
}
