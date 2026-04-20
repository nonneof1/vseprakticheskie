namespace _7prak16
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
                    m[i, j] = rnd.Next(1, 101);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }

            Console.Write("величина: ");
            double val = double.Parse(Console.ReadLine());

            int cnt = 0;
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < c; j++) sum += m[i, j];
                double avg = sum / c;
                Console.WriteLine($"строка {i + 1}: {avg:F2}");
                if (avg < val) cnt++;
            }

            Console.WriteLine($"\nколичество: {cnt}");
        }
    }
}