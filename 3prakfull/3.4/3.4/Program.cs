namespace _3._4
{
    class Program
    {
        static void Main()
        {
            Console.Write("x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("y: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine(x < 2 && y < 3);
            Console.WriteLine(!(x < 2));
            Console.WriteLine(x < 1 || y < 2);
            Console.WriteLine(!(x < 0 && x < 5));
            Console.WriteLine(x < 0 && y > 5);
            Console.WriteLine(x > 10 && x < 20);
            Console.WriteLine(x > 3 || x < 1);
            Console.WriteLine(y > 0 && y < 4 && x < 5);
            Console.WriteLine(x > 3 && x < 10);
        }
    }
}
