namespace _4._3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumocen = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Оценка " + i + ": ");
                sumocen += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Средняя = " + sumocen / 10.0);
        }
    }
}
