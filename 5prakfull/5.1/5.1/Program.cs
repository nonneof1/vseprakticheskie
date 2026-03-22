namespace _5._1
{
    class Program
    {
        static void PrintM(int m, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(m + " ");
        }

        static void Main()
        {
            Console.Write("Введите длину ряда N: ");
            int n = int.Parse(Console.ReadLine());

            int m = 20; 

            PrintM(m, n);
        }
    }
}