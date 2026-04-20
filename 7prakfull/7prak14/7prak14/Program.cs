namespace _7prak14
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Write("строки: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("столбцы: ");
            int c = int.Parse(Console.ReadLine());

            int[,] m = new int[n, c];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < c; j++)
                    m[i, j] = rnd.Next(-50, 51);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int minRow = 0, minCol = 0;
            int minAbs = Math.Abs(m[0, 0]);

            for (int i = 0; i < n; i++)
                for (int j = 0; j < c; j++)
                {
                    int cur = Math.Abs(m[i, j]);
                    if (cur < minAbs)
                    {
                        minAbs = cur;
                        minRow = i;
                        minCol = j;
                    }
                }

            Console.WriteLine($"\nминимум по модулю: {m[minRow, minCol]}");
            Console.WriteLine($"позиция: строка {minRow + 1}, столбец {minCol + 1}");
        }
    }
}