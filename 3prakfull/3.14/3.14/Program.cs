namespace _3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine((n % 10) % 2 == 0);
            Console.WriteLine((n % 10) % 2 != 0);
        }
    }
}
