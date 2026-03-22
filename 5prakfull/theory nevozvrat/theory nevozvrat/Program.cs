namespace theory_nevozvrat
{

    class Program
    {
        static void Stroka(int a)
        {
            Console.WriteLine("Вы передали число " + a);
            Console.WriteLine("Это выводится в теле метода");
        }

        static void Main()
        {
            Stroka(10);
        }
    }
}
