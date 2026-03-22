namespace _4._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Сколько раз вывести: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 0; i < k; i++)
                Console.Write(num + " ");
            Console.WriteLine("\n");
        }
    }
}
