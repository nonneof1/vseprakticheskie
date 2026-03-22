namespace _4._3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n2 = int.Parse(Console.ReadLine());

            int square = 0;

            for (int i = 1; i <= n2; i++)
                square += (2 * i - 1);

            Console.WriteLine("Квадрат = " + square);
        }
    }
}
