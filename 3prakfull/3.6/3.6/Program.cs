namespace _3._6
{
    class Program
    {
        static void Main()
        {
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine(A % 2 == 0 || A % 3 == 0);
            Console.WriteLine(A % 3 != 0 && A % 10 == 0);

            int N = int.Parse(Console.ReadLine());

            Console.WriteLine(N % 5 == 0 || N % 7 == 0);
            Console.WriteLine(N % 4 == 0 && N % 10 != 0);
        }
    }
}