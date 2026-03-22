namespace _3._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double km = double.Parse(Console.ReadLine());
            double feet = double.Parse(Console.ReadLine());

            double meters1 = km * 1000;
            double meters2 = feet * 0.305;

            Console.WriteLine(meters1 < meters2 ? "Км меньше" : "Футы меньше");
        }
    }
}
