namespace _4._3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double run = 10;
            double totalrun = run;

            for (int i = 2; i <= 10; i++)
            {
                run *= 1.1;
                Console.WriteLine("День " + i + ": " + run);
            }

            run = 10;

            for (int i = 2; i <= 7; i++)
            {
                run *= 1.1;
                totalrun += run;
            }

            Console.WriteLine("Сумма за 7 дней = " + totalrun);
        }
    }
}
