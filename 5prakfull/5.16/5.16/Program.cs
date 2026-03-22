using System;

namespace _5._16
{
    internal class Program
    {
        static int Months(double deposit, double percent, double target)
        {
            int months = 0;

            while (deposit < target)
            {
                deposit += deposit * percent / 100;
                months++;
            }

            return months;
        }

        static void Main(string[] args)
        {
            Console.Write("Вклад: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Процент: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Цель: ");
            double t = double.Parse(Console.ReadLine());

            Console.WriteLine("Месяцев: " + Months(d, p, t));
        }
    }
}
