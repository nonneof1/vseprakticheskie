namespace _7prak12
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
                    m[i, j] = rnd.Next(-20, 21);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                int minPos = 0;
                for (int j = 1; j < c; j++)
                    if (m[i, j] < m[i, minPos]) minPos = j;

                int t = m[i, 0];
                m[i, 0] = m[i, minPos];
                m[i, minPos] = t;
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