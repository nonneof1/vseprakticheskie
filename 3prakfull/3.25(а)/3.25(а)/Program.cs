namespace _3._25_а_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите день года (1-365): ");
            int k = int.Parse(Console.ReadLine());

            int day = (k - 1) % 7 + 1;

            string result = "";

            switch (day)
            {
                case 1: result = "Понедельник"; break;
                case 2: result = "Вторник"; break;
                case 3: result = "Среда"; break;
                case 4: result = "Четверг"; break;
                case 5: result = "Пятница"; break;
                case 6: result = "Суббота"; break;
                case 7: result = "Воскресенье"; break;
            }

            Console.WriteLine(result);
        }
    }
}
