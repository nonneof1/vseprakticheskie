namespace _8prak16
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("data.txt"))
            {
                Console.WriteLine("файл не найден");
                return;
            }

            string[] lines = File.ReadAllLines("data.txt");
            var filtered = lines.Where(l => l.Length >= 5).ToArray();

            File.WriteAllLines("filtered.txt", filtered);
            Console.WriteLine("готово");
        }
    }
}