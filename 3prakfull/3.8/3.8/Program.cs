namespace _3._8
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Больше: {Math.Max(a, b)}");
            Console.WriteLine($"Меньше: {Math.Min(a, b)}");
        }
    }
}