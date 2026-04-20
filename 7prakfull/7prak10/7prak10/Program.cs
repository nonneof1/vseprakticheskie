namespace _7prak10
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Write("размер: ");
            int n = int.Parse(Console.ReadLine());

            int[,] m = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    m[i, j] = rnd.Next(-10, 11);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int maxSum = int.MinValue, maxRow = 0;
            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < n; j++) sum += m[i, j];
                if (sum > maxSum) { maxSum = sum; maxRow = i; }
            }

            int[] r = new int[n];
            for (int j = 0; j < n; j++) r[j] = m[maxRow, j];

            Console.WriteLine($"\nстрока {maxRow + 1} (сумма {maxSum}):");
            for (int i = 0; i < n; i++)
                Console.Write($"{r[i],4}");
            Console.WriteLine();
        }
    }
}