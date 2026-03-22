namespace primeri_vipolneniya_zadach
{
    using System;

    class Program
    {
        // 1
        static void Stars(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        // 2
        static int Digits(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n /= 10;
                count++;
            }
            return count;
        }

        // 3
        static int Min(int n1, int n2) => n1 < n2 ? n1 : n2;

        static int Min(int n1, int n2, int n3)
        {
            int min = n1;
            if (min > n2) min = n2;
            if (min > n3) min = n3;
            return min;
        }

        static int Min(int n1, int n2, int n3, int n4)
        {
            int min = n1;
            if (min > n2) min = n2;
            if (min > n3) min = n3;
            if (min > n4) min = n4;
            return min;
        }

        static void Main()
        {
            Stars(5);
            Stars(10);
            Stars(15);

            Console.WriteLine(Digits(10));
            Console.WriteLine(Digits(679));
            Console.WriteLine(Digits(1600));

            Console.WriteLine(Min(10, 99));
            Console.WriteLine(Min(20, 33, 9));
            Console.WriteLine(Min(16, 5, 9, 75));
        }
    }
}
