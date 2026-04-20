namespace _8prak9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("строка: ");
            string s = Console.ReadLine();
            Console.Write("что заменить: ");
            string old = Console.ReadLine();
            Console.Write("на что: ");
            string n = Console.ReadLine();

            Console.WriteLine(s.Replace(old, n));
        }
    }
}