using System;
struct Fraction
{
    public long numerator, denominator;
    public Fraction(long numerator, long denomerator)
        : this()
    {
        this.Numerator = numerator;
        this.Denominator = denomerator;
    }
    public long Numerator 
    {
        
        get { return this.numerator; }
        set
        {
            if (value > long.MaxValue || value < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The numerator must be between -9223372036854775808 and 9223372036854775807");
            }
            this.numerator = value;
        }
    }
    public long Denominator
    {
        get { return this.denominator; }
        set
        {
            if (value > long.MaxValue || value < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The denominator must be between -9223372036854775808 and 9223372036854775807");
            }
            if (value == 0 || value == null)
            {
                throw new ArgumentNullException("The denominator must be set and cant be 0.");
            }
            this.denominator = value;
        }
    }

    public static Fraction operator +(Fraction f, Fraction f2)
    {
        long res1 = (f.Denominator * f.Numerator) + (f.Numerator * f.Denominator);
        long res2 = f.Denominator * f2.Denominator;
        return new Fraction(res1, res2);
    }

    public static Fraction operator -(Fraction f, Fraction f2)
    {
        long res1 = (f.Denominator * f.Numerator) - (f.Numerator * f.Denominator);
        long res2 = f.Denominator * f2.Denominator;
        return new Fraction(res1, res2);
    }
    public override string ToString()
    {
        return string.Format("{0}/{1}", Numerator, Denominator);
    }
}