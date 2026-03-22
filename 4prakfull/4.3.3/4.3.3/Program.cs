namespace _4._3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 20; i <= 35; i++)
                Console.WriteLine(i);

            Console.Write("Введите b (>10): ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 10; i <= b; i++)
                Console.WriteLine(i * i);

            Console.Write("Введите a (<50): ");
            int a = int.Parse(Console.ReadLine());

            for (int i = a; i <= 50; i++)
                Console.WriteLine(i * i * i);

            Console.Write("Введите a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите b (меньше a): ");
            int b1 = int.Parse(Console.ReadLine());

            for (int i = a1; i >= b1; i--)
                Console.WriteLine(i);
        }
    }
}
