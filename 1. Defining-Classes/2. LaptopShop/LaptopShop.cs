using System;

class LaptopShop
{

    static void Main(String[] args)
    {
        Laptop test1 = new Laptop("Lenovo ", 999, new Battery("Lion", 4), "Lenovo", "Intel", 16, "Nvidia", "", "13.4");
        Laptop test2 = new Laptop("HP", 100);

        Console.WriteLine(test1);
        Console.WriteLine(test2);
        Console.ReadLine();
    }
}