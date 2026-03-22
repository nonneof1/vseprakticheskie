using System;

namespace _5._24
{
    internal class Program
    {
        static int Min(int a, int b, int c)
        {
            return Math.Min(a, Math.Min(b, c));
        }

        static int Min(int a, int b, int c, int d)
        {
            return Math.Min(Min(a, b, c), d);
        }

        static int Min(int a, int b, int c, int d, int e)
        {
            return Math.Min(Min(a, b, c, d), e);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите 4 числа:\n");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Минимум (4): " + Min(a, b, c, d));

            Console.Write("Введите 5-е число: ");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Минимум (5): " + Min(a, b, c, d, e));
        }
    }
}
