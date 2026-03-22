namespace _4._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int dec5 = int.Parse(Console.ReadLine());

            string five = "";

            while (dec5 > 0)
            {
                five = (dec5 % 5) + five;
                dec5 = dec5 / 5;
            }

            Console.WriteLine("Результат: " + five);
            Console.WriteLine();
        }
    }
}
