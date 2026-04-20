namespace _8prak12
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("secret.txt"))
            {
                Console.WriteLine("файл не найден");
                return;
            }

            string text = File.ReadAllText("secret.txt");

            string res = "";
            foreach (char c in text)
                if (char.IsLetter(c))
                    res += '*';
                else
                    res += c;

            File.WriteAllText("encrypted.txt", res);
            Console.WriteLine("готово");
        }
    }
}