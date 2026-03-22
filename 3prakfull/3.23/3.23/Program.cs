namespace _3._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер карты (6-14): ");
            int k = int.Parse(Console.ReadLine());

            string name = "";

            switch (k)
            {
                case 6: name = "Шестерка"; break;
                case 7: name = "Семерка"; break;
                case 8: name = "Восьмерка"; break;
                case 9: name = "Девятка"; break;
                case 10: name = "Десятка"; break;
                case 11: name = "Валет"; break;
                case 12: name = "Дама"; break;
                case 13: name = "Король"; break;
                case 14: name = "Туз"; break;
                default: name = "Ошибка"; break;
            }

            Console.WriteLine(name);
        }
    }
}
