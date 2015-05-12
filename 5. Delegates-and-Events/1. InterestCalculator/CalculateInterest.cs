using System;
public delegate void CalculateInterest(decimal money, double interest, int years);

public class InterestCalculator
{
    public decimal Money { get; set; }
    public double Interest { get; set; }
    public int Years { get; set; }
    public CalculateInterest CalculateInterest { get; set; }

    public InterestCalculator(decimal money, double interest, int years, CalculateInterest calculateInterest)
    {
        this.Money = money;
        this.Interest = interest;
        this.Years = years;
        this.CalculateInterest = calculateInterest;
        CalculateInterest call = calculateInterest;
        call(money, interest, years);
    }
    static void GetSimpleInterest(decimal money, double interest, int years)
    {
        double A = (double)money * (1 + (interest * years) / 100);
        string result = A.ToString("0.0000");
        Console.WriteLine(result);
    }

    static void GetCompoundInterest(decimal money, double interest, int years)
    {
        double A = (double)money * (((1 + (interest / 12)) * (12 * years)) / 100);
        string result = A.ToString("0.0000");
        Console.WriteLine(result);
    }
    public static void Main(string[] args)
    {
        InterestCalculator test1 = new InterestCalculator(500m, 5.6, 10, GetCompoundInterest);
        InterestCalculator test2 = new InterestCalculator(2500m, 7.2, 15, GetSimpleInterest);
        Console.ReadLine();
    }
}