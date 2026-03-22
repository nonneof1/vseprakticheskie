namespace _4._3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество предметов: ");
            int count = int.Parse(Console.ReadLine());

            double summass = 0;

            for (int i = 1; i <= count; i++)
            {
                Console.Write("Масса: ");
                summass += double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Средняя масса = " + summass / count);
        }
    }
}
