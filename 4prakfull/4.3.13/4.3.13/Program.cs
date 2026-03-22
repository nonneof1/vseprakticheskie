namespace _4._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumSquares = 0;

            for (int i = 1; i <= 10; i++)
            {
                int sq = 0;
                for (int j = 1; j <= i; j++)
                    sq += (2 * j - 1);

                sumSquares += sq;
            }

            Console.WriteLine("Сумма квадратов = " + sumSquares);
        }
    }
}
