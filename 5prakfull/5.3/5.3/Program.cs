using System;

namespace _5._3
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

        static long SumFactorials(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
                sum += Factorial(i);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма факториалов: " + SumFactorials(n));
        }
    }
}

