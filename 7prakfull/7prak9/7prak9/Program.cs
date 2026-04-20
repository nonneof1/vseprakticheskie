namespace _7prak9
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
                    m[i, j] = rnd.Next(-20, 21);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int min = m[0, 0], max = m[0, 0];
            int minPos = 0, maxPos = 0;

            for (int i = 1; i < n; i++)
            {
                if (m[i, i] < min) { min = m[i, i]; minPos = i; }
                if (m[i, i] > max) { max = m[i, i]; maxPos = i; }
            }

            Console.WriteLine($"\nминимум: {min} [{minPos},{minPos}]");
            Console.WriteLine($"максимум: {max} [{maxPos},{maxPos}]");

            int t = m[minPos, minPos];
            m[minPos, minPos] = m[maxPos, maxPos];
            m[maxPos, maxPos] = t;

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }
        }
    }
}