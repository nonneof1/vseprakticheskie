namespace _8prak13
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("file1.txt") || !File.Exists("file2.txt"))
            {
                Console.WriteLine("файлы не найдены");
                return;
            }

            string t1 = File.ReadAllText("file1.txt");
            string t2 = File.ReadAllText("file2.txt");

            File.WriteAllText("result.txt", t1 + t2);
            Console.WriteLine("готово");
        }
    }
}