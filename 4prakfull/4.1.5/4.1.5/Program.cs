namespace _4._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите двоичное число: ");
            string bin = Console.ReadLine();

            int result10 = 0;
            int i = 0;

            while (bin.Length > 0)
            {
                int digit = bin[bin.Length - 1] - '0';
                result10 += digit * (int)Math.Pow(2, i);

                bin = bin.Substring(0, bin.Length - 1);
                i++;
            }

            Console.WriteLine("Результат: " + result10);
            Console.WriteLine();
        }
    }
}
