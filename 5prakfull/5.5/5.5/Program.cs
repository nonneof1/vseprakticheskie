using System;

namespace _5._5
{
    internal class Program
    {
        static int Square(int n)
        {
            int sum = 0;
            int odd = 1;

            for (int i = 0; i < n; i++)
            {
                sum += odd;
                odd += 2;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Квадрат: " + Square(n));
        }
    }
}