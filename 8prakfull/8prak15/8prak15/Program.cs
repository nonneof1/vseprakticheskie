namespace _8prak15
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("book.txt"))
            {
                Console.WriteLine("файл не найден");
                return;
            }

            string text = File.ReadAllText("book.txt");
            string[] lines = File.ReadAllLines("book.txt");
            string[] words = text.Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"символов: {text.Length}");
            Console.WriteLine($"слов: {words.Length}");
            Console.WriteLine($"строк: {lines.Length}");
        }
    }
}