namespace _7prak13
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[8, 5];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 5; j++)
                    m[i, j] = rnd.Next(20, 41);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.WriteLine("\nстроки с не более 3 четными:");
            for (int i = 0; i < 8; i++)
            {
                int even = 0;
                for (int j = 0; j < 5; j++)
                    if (m[i, j] % 2 == 0) even++;

                if (even <= 3)
                    Console.WriteLine($"строка {i + 1}: {even} четных");
            }
        }
    }
}