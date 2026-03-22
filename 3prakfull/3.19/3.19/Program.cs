namespace _3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a (стол): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b (стол): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("d: ");
            int d = int.Parse(Console.ReadLine());

            Console.Write("e: ");
            int e = int.Parse(Console.ReadLine());

            // 3 варианта граней
            int v1 = (a / c) * (b / d);
            int v2 = (a / c) * (b / e);
            int v3 = (a / d) * (b / e);

            int max = Math.Max(v1, Math.Max(v2, v3));

            Console.WriteLine($"Максимум домино: {max}");
        }
    }
}
