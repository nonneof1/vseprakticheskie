using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите c: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("Введите d: ");
        double d = double.Parse(Console.ReadLine());

        double max = Math.Max(Math.Max(a, b), Math.Max(c, d));
        double min = Math.Min(Math.Min(a, b), Math.Min(c, d));

        Console.WriteLine($"Максимум: {max}");
        Console.WriteLine($"Минимум: {min}");
    }
}