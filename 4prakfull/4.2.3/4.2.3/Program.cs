namespace _4._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            do
            {
                Console.Write("Введите число от 1 до 100: ");
                x = int.Parse(Console.ReadLine());

            } while (x < 1 || x > 100);

            Console.WriteLine("Вы ввели: " + x);
            Console.WriteLine();

        }
    }
}
