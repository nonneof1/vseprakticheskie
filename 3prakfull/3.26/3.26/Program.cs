namespace _3._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество месяцев: ");
            int n = int.Parse(Console.ReadLine());

            int month = (n + 2) % 12;
            if (month == 0) month = 12;

            string name = "";

            switch (month)
            {
                case 1: name = "Январь"; break;
                case 2: name = "Февраль"; break;
                case 3: name = "Март"; break;
                case 4: name = "Апрель"; break;
                case 5: name = "Май"; break;
                case 6: name = "Июнь"; break;
                case 7: name = "Июль"; break;
                case 8: name = "Август"; break;
                case 9: name = "Сентябрь"; break;
                case 10: name = "Октябрь"; break;
                case 11: name = "Ноябрь"; break;
                case 12: name = "Декабрь"; break;
            }

            Console.WriteLine(name);
        }
    }
}
