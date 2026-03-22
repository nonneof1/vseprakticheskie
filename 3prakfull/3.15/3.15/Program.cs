namespace _3._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double circle = Math.PI * R * R;
            double square = a * a;

            Console.WriteLine(circle > square ? "Круг больше" : "Квадрат больше");
        }
    }
}
