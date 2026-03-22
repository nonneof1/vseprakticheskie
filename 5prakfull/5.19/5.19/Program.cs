using System;

namespace _5._19
{
    internal class Program
    {
        static double yield(int n)
        {
            double y = 20;
            for (int i = 1; i < n; i++)
                y *= 1.02;
            return y;
        }

        static double area(int n)
        {
            double a = 100;
            for (int i = 1; i < n; i++)
                a *= 1.05;
            return a;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Урожайность: " + yield(n));
            Console.WriteLine("Площадь: " + area(n));
        }
    }
}
