namespace _4._3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 0;
            double total = 0;
            int direction = 1; 

            for (int i = 1; i <= 100; i++)
            {
                double step = 1.0 / i;
                distance += direction * step;
                total += step;
                direction *= -1;
            }

            Console.WriteLine("Расстояние от дома: " + distance);
            Console.WriteLine("Общий путь: " + total);
        }
    }
}
