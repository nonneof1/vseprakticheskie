using System;

namespace _5._9
{
    internal class Program
    {
        static void printdigits(int n)
        {
            while (n > 0)
            {
                Console.Write(n % 10 + " ");
                n /= 10;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());

            printdigits(n);
        }
    }
}