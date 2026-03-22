using System;

namespace _5._13
{
    internal class Program
    {
        static void fibonacci(int m)
        {
            int a = 0, b = 1;

            while (a <= m)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int m = int.Parse(Console.ReadLine());

            fibonacci(m);
        }
    }
}
