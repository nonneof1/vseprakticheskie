namespace _3._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            bool leap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            Console.WriteLine(leap);
        }
    }
}
