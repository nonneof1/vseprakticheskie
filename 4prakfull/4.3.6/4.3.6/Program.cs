namespace _4._3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            double result = 0;
            double x_pow = x; 

            for (int i = 1; i <= 11; i += 2)
            {
                result += x_pow / i;
                x_pow *= x * x; 
            }

            Console.WriteLine("Результат = " + result);
        }
    }
}
