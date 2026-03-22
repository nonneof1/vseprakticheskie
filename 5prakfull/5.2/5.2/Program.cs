using System;

namespace _5._2
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

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Факториал: " + Factorial(k));
        }
    }
}