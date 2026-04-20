using System.Data;

namespace _8prak17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("выражение: ");
            string expr = Console.ReadLine();

            try
            {
                var res = new DataTable().Compute(expr, null);
                Console.WriteLine(res);
            }
            catch
            {
                Console.WriteLine("ошибка");
            }
        }
    }
}