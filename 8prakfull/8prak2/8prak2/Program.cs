namespace _8prak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("буква: ");
            char ch = Console.ReadLine()[0];

            if (char.IsUpper(ch))
                Console.WriteLine(char.ToLower(ch));
            else
                Console.WriteLine(char.ToUpper(ch));
        }
    }
}