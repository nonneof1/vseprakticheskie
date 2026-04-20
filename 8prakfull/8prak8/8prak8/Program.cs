using System.Text;

namespace _8prak8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("строка: ");
            string s = Console.ReadLine();

            StringBuilder res = new StringBuilder();
            foreach (char c in s)
                if (!char.IsDigit(c))
                    res.Append(c);

            Console.WriteLine(res.ToString());
        }
    }
}