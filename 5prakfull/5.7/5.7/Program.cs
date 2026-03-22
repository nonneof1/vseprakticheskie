using System;

namespace _5._7
{
    internal class Program
    {
        static double alternatingsum(int n)
        {
            double sum = 0;
            int sign = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / i);
                sign *= -1;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма: " + alternatingsum(n));
        }
    }
}