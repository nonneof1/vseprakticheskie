namespace _4._1._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в 7-ой системе: ");
            string seven = Console.ReadLine();

            int result7 = 0;
            int j = 0;

            while (seven.Length > 0)
            {
                int digit = seven[seven.Length - 1] - '0';
                result7 += digit * (int)Math.Pow(7, j);

                seven = seven.Substring(0, seven.Length - 1);
                j++;
            }

            Console.WriteLine("Результат: " + result7);

            Console.ReadKey();
        }
    }
}
