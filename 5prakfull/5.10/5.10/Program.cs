using System;

namespace _5._10
{
    internal class Program
    {
        static string tobase(int n, int b)
        {
            string result = "";

            while (n > 0)
            {
                result = (n % b) + result;
                n /= b;
            }

            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите число (10 СС): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите систему счисления (до 10): ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат: " + tobase(n, b));
        }
    }
}