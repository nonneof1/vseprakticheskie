namespace _3._7
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y;

            if (x > 0)
                y = Math.Sin(x);
            else
                y = Math.Cos(x);

            Console.WriteLine(y);
        }
    }
}