using System;

namespace _5._8
{
    internal class Program
    {
        static double seriesx(double x)
        {
            double sum = 0;
            double power = x;

            for (int i = 1; i <= 11; i += 2)
            {
                sum += power / i;
                power *= x * x;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Сумма ряда: " + seriesx(x));
        }
    }
}