namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1 Проект 2."; //огласление программы
            Console.WindowWidth = 60; //размер окна
            Console.WindowHeight = 13; //размер окна
            Console.BackgroundColor = ConsoleColor.Blue; //цвет
            Console.Clear();
            Console.SetCursorPosition(15, 6); //позиция курсора
            Console.WriteLine("Напишите свое имя: ");
            string Name = Console.ReadLine();
            //Console.Write("Привет! ");
            //Console.WriteLine(Name);
            Console.WriteLine("Привет {0}!", Name);
            Console.Write("Для завершения нажмите любую из клавиш...");
            Console.ReadKey();
        }
    }
}
