namespace _7prak15
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
                    m[i, j] = rnd.Next(1, 21);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int total = n * c;
            int[] f = new int[total];
            int idx = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < c; j++)
                    f[idx++] = m[i, j];

            int w = 0;
            for (int i = 0; i < total; i++)
            {
                if (f[i] < a || f[i] > b)
                    f[w++] = f[i];
            }

            for (int i = w; i < total; i++)
                f[i] = 0;

            idx = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < c; j++)
                    m[i, j] = f[idx++];

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