namespace _3._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            int day = k % 7;

            if (day == 6 || day == 0)
                Console.WriteLine("Выходной");
            else
                Console.WriteLine("Рабочий");
        }
    }
}
