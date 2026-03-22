namespace _3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a (длина стола): ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b (ширина стола): ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("c (длина прямоугольника): ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("d (ширина прямоугольника): ");
            int d = int.Parse(Console.ReadLine());

            int option1 = (a / c) * (b / d);

            int option2 = (a / d) * (b / c);

            Console.WriteLine($"Вдоль длинной стороны: {option1}");
            Console.WriteLine($"Вдоль короткой стороны: {option2}");

            if (option1 > option2)
                Console.WriteLine("Лучше вдоль длинной стороны");
            else if (option2 > option1)
                Console.WriteLine("Лучше вдоль короткой стороны");
            else
                Console.WriteLine("Одинаково");
        }
    }
}
