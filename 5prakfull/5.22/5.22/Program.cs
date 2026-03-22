using System;

namespace _5._22
{
    internal class Program
    {
        static double distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Введите y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Введите x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Введите y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние: " + distance(x1, y1, x2, y2));
        }
    }
}
