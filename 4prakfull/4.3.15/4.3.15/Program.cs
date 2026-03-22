namespace _4._3._15
{
    internal class Program
    {
        private static int fact;
        private static int nf;

        static void Main(string[] args)
        {
            double sumE = 1;
            fact = 1;

            for (int i = 1; i <= nf; i++)
            {
                fact *= i;
                sumE += 1.0 / fact;
            }

            Console.WriteLine("Сумма = " + sumE);

            Console.ReadKey();
        }
    }
}
