namespace _7prak17
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
                    m[i, j] = rnd.Next(0, 11);

            m[0, 0] = 0;
            m[1, 2] = 0;
            if (n > 2) m[2, 1] = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int swap = n - 1;
            bool allZero = true;
            for (int j = 0; j < c; j++)
                if (m[swap, j] != 0) { allZero = false; break; }

            if (allZero && n > 1) swap = n - 2;

            Console.WriteLine($"\nстрока для обмена: {swap + 1}");

            int pos = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < c; j++)
                    if (m[i, j] == 0 && i != swap)
                    {
                        int t = m[i, j];
                        m[i, j] = m[swap, pos];
                        m[swap, pos] = t;

                        pos++;
                        if (pos >= c) pos = 0;
                    }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }
        }
    }
}