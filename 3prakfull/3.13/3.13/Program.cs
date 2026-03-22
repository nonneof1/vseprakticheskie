namespace _3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kmh = double.Parse(Console.ReadLine());
            double ms = double.Parse(Console.ReadLine());

            double ms1 = kmh / 3.6;

            Console.WriteLine(ms1 > ms ? "Км/ч больше" : "м/с больше");
        }
    }
}
