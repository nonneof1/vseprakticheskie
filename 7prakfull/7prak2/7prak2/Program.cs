namespace _7prak2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("одномерный:");
            Print(arr);

            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("\nдвумерный:");
            Print(m);
        }

        static void Print(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write($"{a[i],4}");
            Console.WriteLine();
        }

        static void Print(int[,] m)
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                    Console.Write($"{m[i, j],6}");
                Console.WriteLine();
            }
        }
    }
}