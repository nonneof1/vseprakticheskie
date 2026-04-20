namespace _7prak4
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[6, 11];
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 11; j++)
                    m[i, j] = rnd.Next(-100, 101);

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 11; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int sum = 0;
            Console.WriteLine();
            for (int j = 0; j < 11; j++)
            {
                int max = m[0, j];
                for (int i = 1; i < 6; i++)
                    if (m[i, j] > max) max = m[i, j];
                Console.WriteLine($"столбец {j + 1}: максимум = {max}");
                sum += max;
            }
            Console.WriteLine($"\nсумма: {sum}");
        }
    }
}