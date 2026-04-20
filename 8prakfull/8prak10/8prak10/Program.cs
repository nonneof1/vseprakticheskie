namespace _8prak10
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("input.txt"))
            {
                Console.WriteLine("файл не найден");
                return;
            }

            string text = File.ReadAllText("input.txt");
            Console.WriteLine(text);
        }
    }
}