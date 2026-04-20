namespace _7prak8
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[4, 6];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 6; j++)
                    m[i, j] = rnd.Next(1, 21);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            int[] s = new int[4];
            for (int i = 0; i < 4; i++)
            {
                s[i] = 0;
                for (int j = 0; j < 6; j++)
                    s[i] += m[i, j];
            }

            Console.WriteLine();
            for (int i = 0; i < 4; i++)
                Console.Write($"{s[i],4}");
            Console.WriteLine();

            int max = s[0];
            for (int i = 1; i < 4; i++)
                if (s[i] > max) max = s[i];

            Console.WriteLine($"максимум: {max}");
        }
    }
}