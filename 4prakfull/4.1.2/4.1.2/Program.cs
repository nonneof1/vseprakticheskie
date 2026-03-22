namespace _4._1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальную сумму: ");
            double money = double.Parse(Console.ReadLine());

            int months = 0;

            while (money < 100000)
            {
                money += money * 0.02;
                months++;
            }

            Console.WriteLine("Через месяцев: " + months);
            Console.WriteLine();

        }
    }
}
