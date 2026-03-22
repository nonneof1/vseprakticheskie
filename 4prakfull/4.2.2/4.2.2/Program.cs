using System;

namespace _4._2._2
{
    internal class Program
    {
        private static int sum;
        private static int num;

        static void Main(string[] args)
        {
            int count = 0;
            sum = 0;

            do
            {
                Console.Write("Введите число (0 для выхода): ");
                num = int.Parse(Console.ReadLine());

                if (num != 0)
                {
                    sum += num;
                    count++;
                }

            } while (num != 0);

            if (count > 0)
                Console.WriteLine("Среднее = " + (sum / (double)count));
            else
                Console.WriteLine("Нет данных");

            Console.WriteLine();
        }
    }
}
