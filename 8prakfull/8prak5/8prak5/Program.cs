namespace _8prak5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("строка: ");
            string s = Console.ReadLine();

            string res = "";
            for (int i = s.Length - 1; i >= 0; i--)
                res += s[i];

            Console.WriteLine(res);
        }
    }
}