using System;

namespace _5._23
{
    internal class Program
    {
        static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Минимум: " + Min(a, b, c));
        }
    }
}
