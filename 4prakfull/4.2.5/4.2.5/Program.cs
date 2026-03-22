namespace _4._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите M: ");
            int M = int.Parse(Console.ReadLine());

            int a = 0, b = 1;

            do
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;

            } while (a <= M);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
