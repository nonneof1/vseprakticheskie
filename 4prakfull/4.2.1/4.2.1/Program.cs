namespace _4._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0;

            do
            {
                Console.Write("Введите число (0 для выхода): ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            } while (num != 0);

            Console.WriteLine("Сумма = " + sum);
            Console.WriteLine();
        }
    }
}
