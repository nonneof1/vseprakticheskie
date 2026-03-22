namespace _3._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(b % a == 0);
            Console.WriteLine(a % b == 0);
        }
    }
}
