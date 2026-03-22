using System;

namespace _5._12
{
    internal class Program
    {
        static int inputnumber()
        {
            int n;
            do
            {
                Console.Write("Введите число (1-100): ");
                n = int.Parse(Console.ReadLine());
            }
            while (n < 1 || n > 100);

            return n;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Вы ввели: " + inputnumber());
        }
    }
}
