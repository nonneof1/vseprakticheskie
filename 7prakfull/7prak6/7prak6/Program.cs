namespace _7prak6
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[,] m = new int[5, 10];
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 10; j++)
                    m[i, j] = rnd.Next(-10, 31);

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 10; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("\nстроки только с положительными: ");
            bool first = true;
            for (int i = 0; i < 5; i++)
            {
                bool pos = true;
                for (int j = 0; j < 10; j++)
                    if (m[i, j] <= 0) { pos = false; break; }

                if (pos)
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