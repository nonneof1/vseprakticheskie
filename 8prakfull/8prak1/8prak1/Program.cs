namespace _8prak1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("символ: ");
            char ch = Console.ReadLine()[0];

            if (char.IsDigit(ch))
                Console.WriteLine("цифра");
            else if (char.IsLetter(ch))
                Console.WriteLine("буква");
            else
                Console.WriteLine("спецсимвол");
        }
    }
}