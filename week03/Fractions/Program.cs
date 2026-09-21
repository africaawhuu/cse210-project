using System;

class Program
{
    static void Main(string[] args)
    {
        // Verify Constructors
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Verify Getters and Setters
        Fraction testFraction = new Fraction();
        testFraction.SetTop(6);
        testFraction.SetBottom(7);
        
        Console.WriteLine($"\nTesting Getters after setting top to 6 and bottom to 7:");
        Console.WriteLine($"Top: {testFraction.GetTop()}");
        Console.WriteLine($"Bottom: {testFraction.GetBottom()}");
        Console.WriteLine($"Result: {testFraction.GetFractionString()}");
    }
}