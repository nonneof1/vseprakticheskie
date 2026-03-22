namespace _4._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Цифры числа: ");
            while (n > 0)
            {
                Console.Write(n % 10 + " ");
                n = n / 10;
            }
            Console.WriteLine("\n");
        }
    }
}
