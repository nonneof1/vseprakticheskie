namespace _8prak11
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("text.txt"))
            {
                Console.WriteLine("файл не найден");
                return;
            }

            Console.Write("слово: ");
            string word = Console.ReadLine();

            string text = File.ReadAllText("text.txt");
            string[] words = text.Split(new[] { ' ', '\n', '\r', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            int count = 0;
            foreach (string w in words)
                if (w.ToLower() == word.ToLower())
                    count++;

            Console.WriteLine(count);
        }
    }
}