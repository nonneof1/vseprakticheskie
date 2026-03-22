using System;

namespace _5._17
{
    internal class Program
    {
        static double daydistance(int n)
        {
            double d = 10;
            for (int i = 1; i < n; i++)
                d *= 1.1;
            return d;
        }

        static double totaldistance(int n)
        {
            double sum = 0, d = 10;

            for (int i = 1; i <= n; i++)
            {
                sum += d;
                d *= 1.1;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("День N: " + daydistance(n));
            Console.WriteLine("Сумма: " + totaldistance(n));
        }
    }
}
