using System;

namespace _5._18
{
    internal class Program
    {
        static double distancefromhome(int n)
        {
            double pos = 0;
            int dir = 1;

            for (int i = 1; i <= n; i++)
            {
                pos += dir * (1.0 / i);
                dir *= -1;
            }

            return pos;
        }

        static double totalpath(int n)
        {
            double sum = 0;

            for (int i = 1; i <= n; i++)
                sum += 1.0 / i;

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Расстояние: " + distancefromhome(n));
            Console.WriteLine("Путь: " + totalpath(n));
        }
    }
}
