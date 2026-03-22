using System;

class Program
{
    static void Main()
    {
        Console.Write("x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("ширина1: ");
        double w1 = double.Parse(Console.ReadLine());
        Console.Write("высота1: ");
        double h1 = double.Parse(Console.ReadLine());

        Console.Write("x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = double.Parse(Console.ReadLine());
        Console.Write("ширина2: ");
        double w2 = double.Parse(Console.ReadLine());
        Console.Write("высота2: ");
        double h2 = double.Parse(Console.ReadLine());

        double r1 = x1 + w1;
        double t1 = y1 + h1;

        double r2 = x2 + w2;
        double t2 = y2 + h2;

        bool a = x1 >= x2 && y1 >= y2 && r1 <= r2 && t1 <= t2;

        bool b = a || (x2 >= x1 && y2 >= y1 && r2 <= r1 && t2 <= t1);

        bool c = !(r1 <= x2 || r2 <= x1 || t1 <= y2 || t2 <= y1);

        Console.WriteLine($"а) Первый внутри второго: {a}");
        Console.WriteLine($"б) Один внутри другого: {b}");
        Console.WriteLine($"в) Пересекаются: {c}");
    }
}