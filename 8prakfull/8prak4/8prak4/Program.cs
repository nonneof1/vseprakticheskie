namespace _8prak4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("буква: ");
            char ch = char.ToLower(Console.ReadLine()[0]);

            string glas = "aeiouy";

            if (glas.Contains(ch))
                Console.WriteLine("гласная");
            else
                Console.WriteLine("не гласная");
        }
    }
}