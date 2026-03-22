using System;

namespace _5._4
{
    internal class Program
    {
        static long Factorial(int k)
        {
            long result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }

        static double SumSeries(int n)
        {
            double sum = 1;
            for (int i = 1; i <= n; i++)
                sum += 1.0 / Factorial(i);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма ряда: " + SumSeries(n));
        }
    }
}