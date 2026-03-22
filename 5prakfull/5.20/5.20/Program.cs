using System;

namespace _5._20
{
    internal class Program
    {
        static int perimeter(int a, int b, int c)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите сторону a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону c: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Периметр: " + perimeter(a, b, c));
        }
    }
}
