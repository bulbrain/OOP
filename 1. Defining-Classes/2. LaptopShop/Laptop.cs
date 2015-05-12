using System;

public class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphics;
    private string hdd;
    private string screen;
    private double price;
    public Battery Batt;

    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, double price, Battery batt, string manufact)
        : this(model, price)
    {
        this.Batt = batt;
        this.Manufacturer = manufact;
    }

    public Laptop(string model, double price, Battery battery, string manufact = null, string processor = null,
        int ram = 0, string video = null, string hdd = null, string screen = null)
        : this(model, price, battery, manufact)
    {
        this.Processor = processor;
        this.Ram = ram;
        this.Graphics = video;
        this.Hdd = hdd;
        this.Screen = screen;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentNullException("The model of the laptop is mandatory!");
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
        set { this.manufacturer = value; }
    }

    public string Processor
    {
        get { return this.processor; }
        set { this.processor = value; }
    }

    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Ram must be > 0");
            this.ram = value;
        }
    }

    public string Graphics
    {
        get { return this.graphics; }
        set { this.graphics = value; }
    }

    public string Hdd
    {
        get { return this.hdd; }
        set { this.hdd = value; }
    }

    public string Screen
    {
        get { return this.screen; }
        set { this.screen = value; }
    }

    public double Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("The price must be set and > 0");
            this.price = value;
        }
    }

    public void AddBattery(Battery battery)
    {
        this.Batt = battery;
    }

    public override string ToString()
    {
        string output = "Model: " + this.model + "\n";
        if (!String.IsNullOrEmpty(this.Manufacturer))
            output += "Manufacturer: " + this.Manufacturer + "\n";
        if (!String.IsNullOrEmpty(this.Processor))
            output += "Processor: " + this.Processor + "\n";
        if (this.Ram != 0)
            output += "RAM: " + this.Ram + " GB" + "\n";
        if (!String.IsNullOrEmpty(this.Graphics))
            output += "Graphics card: " + this.Graphics + "\n";
        if (!String.IsNullOrEmpty(this.Hdd))
            output += "HDD: " + this.Hdd + "\n";
        if (!String.IsNullOrEmpty(this.Screen))
            output += "Screen: " + this.Screen + "\n";
            output += this.Batt;

        output += "Price: " + this.price + " lv.\n";
        return output;
    }
}
