
namespace theory_vozvrat;

using System;

class Program
{
    static double Summa(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        double result = Summa(5.5, 4.5);
        Console.WriteLine("Сумма: " + result);
    }
}
