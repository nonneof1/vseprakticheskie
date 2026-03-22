using System;

namespace _5._6
{
    internal class Program
    {
        static int square(int n)
        {
            int sum = 0, odd = 1;
            for (int i = 0; i < n; i++)
            {
                sum += odd;
                odd += 2;
            }
            return sum;
        }

        static int sumsquares(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += square(i);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма квадратов: " + sumsquares(n));
        }
    }
}
