using System;

namespace _5._21
{
    internal class Program
    {
        static int getpow(int a, int n)
        {
            int res = 1;

            for (int i = 0; i < n; i++)
                res *= a;

            return res;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите степень: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат: " + getpow(a, n));
        }
    }
}
