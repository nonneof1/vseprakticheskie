namespace _4._3._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area = 100;
            double yield = 20;
            double totalharvest = 0;

            for (int year = 1; year <= 8; year++)
            {
                double harvest = area * yield;

                if (year >= 2)
                    Console.WriteLine("Урожайность " + year + ": " + yield);

                if (year >= 4 && year <= 7)
                    Console.WriteLine("Площадь " + year + ": " + area);

                if (year <= 6)
                    totalharvest += harvest;

                area *= 1.05;
                yield *= 1.02;
            }

            Console.WriteLine("Общий урожай за 6 лет = " + totalharvest);
        }
    }
}
