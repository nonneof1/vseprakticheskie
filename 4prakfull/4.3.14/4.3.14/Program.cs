namespace _4._3._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите n (<=10): ");
            int nf = int.Parse(Console.ReadLine());

            int fact = 1;
            int sumfact = 0;

            for (int i = 1; i <= nf; i++)
            {
                fact *= i;
                sumfact += fact;
            }

            Console.WriteLine("Сумма факториалов = " + sumfact);
        }
    }
}
