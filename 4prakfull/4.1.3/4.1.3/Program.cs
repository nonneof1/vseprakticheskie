namespace _4._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int dec = int.Parse(Console.ReadLine());

            string binary = "";

            while (dec > 0)
            {
                binary = (dec % 2) + binary;
                dec = dec / 2;
            }

            Console.WriteLine("Результат: " + binary);
            Console.WriteLine();
        }
    }
}
