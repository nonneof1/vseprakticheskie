namespace _7prak7
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[7, 4];
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 4; j++)
                    m[i, j] = rnd.Next(-15, 16);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("\nстроки с нечетным отрицательным: ");
            bool first = true;
            for (int i = 0; i < 7; i++)
            {
                bool odd = false;
                for (int j = 0; j < 4; j++)
                    if (m[i, j] < 0 && m[i, j] % 2 != 0)
                    { odd = true; break; }

                if (odd)
                {
                    if (!first) Console.Write(", ");
                    Console.Write(i + 1);
                    first = false;
                }
            }
            if (first) Console.Write("нет");
            Console.WriteLine();
        }
    }
}