using System;

namespace _5._25
{
    internal class Program
    {
        static int sum(int a, int b) => a + b;
        static int sum(int a, int b, int c) => a + b + c;
        static int sum(int a, int b, int c, int d) => a + b + c + d;

        static void Main(string[] args)
        {
            Console.Write("Введите 2 числа:\n");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма (2): " + sum(a, b));

            Console.Write("Введите 3-е число: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма (3): " + sum(a, b, c));

            Console.Write("Введите 4-е число: ");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Сумма (4): " + sum(a, b, c, d));
        }
    }
}
