namespace _8prak7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("предложение: ");
            string s = Console.ReadLine();

            string[] words = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }
    }
}