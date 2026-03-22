namespace _3._5
{
    class Program
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            Console.WriteLine(A > 100 && B > 100);
            Console.WriteLine(A > 0 || B > 0);
            Console.WriteLine(A % 3 == 0 && B % 3 == 0 && C % 3 == 0);
            Console.WriteLine((A < 50 ? 1 : 0) + (B < 50 ? 1 : 0) + (C < 50 ? 1 : 0) == 1);
            Console.WriteLine(A < 0 || B < 0 || C < 0);
        }
    }
}