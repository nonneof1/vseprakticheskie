namespace _4._3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 25; i++)
                Console.WriteLine(i + " " + (i + 0.4));

            for (int i = 25; i <= 35; i++)
                Console.WriteLine(i + " " + (i + 0.5) + " " + (i - 0.2));
        }
    }
}
