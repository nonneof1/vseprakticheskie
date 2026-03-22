using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;

        double min = a;
        if (b < min) min = b;
        if (c < min) min = c;

        Console.WriteLine(max);
        Console.WriteLine(min);
    }
}