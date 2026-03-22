namespace _3._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите месяц (1-12): ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите день: ");
            int n = int.Parse(Console.ReadLine());

            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            int prevDay = n - 1;
            int prevMonth = m;

            if (prevDay == 0)
            {
                prevMonth--;
                prevDay = days[prevMonth - 1];
            }

            int nextDay = n + 1;
            int nextMonth = m;

            if (nextDay > days[m - 1])
            {
                nextDay = 1;
                nextMonth++;
            }

            Console.WriteLine($"Предыдущий день: {prevDay}.{prevMonth}");
            Console.WriteLine($"Следующий день: {nextDay}.{nextMonth}");
        }
    }
}
