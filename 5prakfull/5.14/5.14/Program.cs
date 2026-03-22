using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace _5._14
{
    internal class Program
    {
        static double averagegrades()
        {
            int sum = 0;
 
            Console.WriteLine("Введите 10 оценок:");
            for (int i = 0; i < 10; i++)
                sum += int.Parse(Console.ReadLine());

            return sum / 10.0;
            // я бы мог сделать цикл и поставить максимум допустимой оценки 5,но мне лень и этого нет в задании    
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Средняя оценка: " + averagegrades());
        }
    }
}
