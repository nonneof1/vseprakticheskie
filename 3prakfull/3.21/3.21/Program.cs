namespace _3._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = double.Parse(Console.ReadLine());

            t %= 5;

            if (t < 3)
                Console.WriteLine("Зеленый");
            else
                Console.WriteLine("Красный");
        }
    }
}
