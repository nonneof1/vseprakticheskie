namespace _7prak1
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.Write("минимум: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("максимум: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("строки: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("столбцы: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] m = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    m[i, j] = rnd.Next(a, b + 1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }
        }
    }
}