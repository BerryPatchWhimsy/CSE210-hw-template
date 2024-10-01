using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        // f2.SetTop(3);
        // Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(1,3);
        // f3.SetTop(6);
        // f3.SetBottom(7);
        // Console.WriteLine(f3.GetTop());
        // Console.WriteLine(f3.GetBottom());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

    }

    
}

