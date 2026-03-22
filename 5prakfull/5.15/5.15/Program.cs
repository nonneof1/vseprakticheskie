using System;

namespace _5._15
{
    internal class Program
    {
        static double averagemass(int n)
        {
            double sum = 0;

            for (int i = 0; i < n; i++)
                sum += double.Parse(Console.ReadLine());

            return sum / n;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество предметов: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Средняя масса: " + averagemass(n));
        }
    }
}
