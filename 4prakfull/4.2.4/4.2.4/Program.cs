namespace _4._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int r;
            int tries = 0;

            do
            {
                r = rnd.Next(1, 11); // от 1 до 10
                Console.Write(r + " ");
                tries++;

            } while (r != 7);

            Console.WriteLine("\nПопыток: " + tries);
            Console.WriteLine();
        }
    }
}
