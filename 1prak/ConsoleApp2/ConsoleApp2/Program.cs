namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1";

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("C# — это современный, \n\tс открытым исходным кодом, \n\t\tобъектно-ориентированный \n\t\t\tязык программирования”.");

            Console.Write("Нажми любую клавишу...");
            Console.ReadKey();
        }
    }
}
