using System;

class Program
{
    
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        System.Console.WriteLine(fraction.GetFractionString());
        System.Console.WriteLine(fraction.GetDecimalValue());

        Fraction f1 = new Fraction(5);
        System.Console.WriteLine(f1.GetFractionString());
        System.Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5,5);
        System.Console.WriteLine(f2.GetFractionString());
        System.Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(9,53);
        System.Console.WriteLine(f3.GetFractionString());
        System.Console.WriteLine(f3.GetDecimalValue());
    }
}