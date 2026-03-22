namespace _3._3
{
    class Program
    {
        static void Main()
        {
            bool x = true, y = false, z = true;

            Console.WriteLine(!(x || y) || (y == x));
            Console.WriteLine((x || y) == (y && x));
            Console.WriteLine((x && y) || (!y || x));
            Console.WriteLine(!(x == y) || y);
            Console.WriteLine(!(x || y) || (z == x));
            Console.WriteLine((x == (z || y)) || ((!x || z) && (!y || x)));
            Console.WriteLine(!y || (z == x));
            Console.WriteLine(x == (!y || z));
        }
    }
}