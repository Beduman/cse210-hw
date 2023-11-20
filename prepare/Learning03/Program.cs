using System;

class Program
{

    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);
        
        Console.WriteLine(fraction1.GetFraction());
        Console.WriteLine(fraction1.GetDecimal());


        Console.WriteLine(fraction2.GetFraction());
        Console.WriteLine(fraction2.GetDecimal());


        Console.WriteLine(fraction3.GetFraction());
        Console.WriteLine(fraction3.GetDecimal());


        Console.WriteLine(fraction4.GetFraction());
        Console.WriteLine(fraction4.GetDecimal());
    }
}