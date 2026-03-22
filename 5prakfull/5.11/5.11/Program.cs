using System;

namespace _5._11
{
    internal class Program
    {
        static int frombase(string num, int b)
        {
            int result = 0;

            foreach (char c in num)
                result = result * b + (c - '0');

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string num = Console.ReadLine();

            Console.Write("Введите систему счисления: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("В 10 СС: " + frombase(num, b));
        }
    }
}
