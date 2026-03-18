using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите A (true/false): ");
        bool A = bool.Parse(Console.ReadLine());

        Console.Write("Введите B (true/false): ");
        bool B = bool.Parse(Console.ReadLine());

        bool a = !(!A && !B) && A;
        bool b = !(!A || !B) || A;
        bool c = !(!A || !B) && B;

        Console.WriteLine($"а) {a}");
        Console.WriteLine($"б) {b}");
        Console.WriteLine($"в) {c}");
    }
}