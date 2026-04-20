namespace _7prak3
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[15, 9];
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 9; j++)
                    m[i, j] = rnd.Next(-50, 51);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 0; i < 15; i++)
            {
                int min = m[i, 0];
                for (int j = 1; j < 9; j++)
                    if (m[i, j] < min) min = m[i, j];
                Console.WriteLine($"строка {i + 1}: минимум = {min}");
            }
        }
    }
}