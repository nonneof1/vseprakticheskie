namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("введи начало диапозона: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("введи end диапозона: ");
            int b = int.Parse(Console.ReadLine());
            int randomnumber = rnd.Next(a, b + 1);
            Console.WriteLine("Случайное число из диапозона [{0}, {1}]: {2}", a, b, randomnumber);

            Console.WriteLine("нажми любую клавишу: ");
            Console.ReadKey();

            ///
            float a111 = 3.2f;
            decimal b111 = 2.6m;
            double c111 = 4.5;
            c111 = (double)a111 + (double)b111 + c111;
            Console.WriteLine($"6 задание. Сумма с: {c111}");
            ////

            int a777 = 3;
            double b777 = 2.6;
            double sum777 = a777 + b777;
            Console.WriteLine($"7 задание. Сумма: {sum777}");
            ////

            Console.Write("Введите целое число a: ");
            int a888 =
                Convert.ToInt32(Console.ReadLine());
            int square = a888 * a888;
            Console.WriteLine($"8 задание. Квадрат числа {a888} = {square}");
            ////

            double number999 = 123.456789;
            double choto999 = Math.Round(number999, 2);
            Console.WriteLine($"9 Задание. Число: {number999}, с точностью до сотых:{choto999}");
            ////

            double e = Math.E;
            double desyatE = Math.Round(e, 1);
            Console.WriteLine($"Задание 10. Число е с точностью до десятых: {desyatE}");

            ///

            Console.Write("Введите число: ");
            int x1111 = int.Parse(Console.ReadLine());

            Console.WriteLine("11 Звдвние. Вы ввели число" + x1111);

            ///

            Console.Write("Введите число: ");
            int x1112 = int.Parse(Console.ReadLine());

            Console.WriteLine("12 Задание. ", x1112 + " - вот такое число вы ввели ");

            ///

            Console.WriteLine("13 Задание. 1 13 49");

            ///

            Console.WriteLine("14 Задание. 7  15  100");

            ///

            float z115;
            int a115 = 1, b115 = 2, c115 = 3;
            const int m115 = 3;

            z115 = (a115 + b115 + c115) / (float)m115;
            Console.WriteLine("15 Задание. ", z115);

            ///

            Console.Write("Введите 1 число: ");
            int a116 = int.Parse(Console.ReadLine());

            Console.Write("Введите 2 число: ");
            int b116 = int.Parse(Console.ReadLine());

            double arithmetic = (a116 + b116) / 2.0;
            double geometric = Math.Sqrt(a116 * b116);

            Console.WriteLine("16 Задание. Среднее арифметическое = " + arithmetic);
            Console.WriteLine("Среднее геометрическое = " + geometric);

            ///

            Console.Write("Введите массу: ");
            double m117 = double.Parse(Console.ReadLine());

            Console.Write("Введите объем: ");
            double v = double.Parse(Console.ReadLine());

            double p = m117 / v;

            Console.WriteLine("17 Задание. Плотность = " + p);

            ///

            Console.Write("Введите a: ");
            double a118 = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b118 = double.Parse(Console.ReadLine());

            double x118 = -b118 / a118;

            Console.WriteLine("18 Задание. x = " + x118);

            ///

            Console.Write("Введите a: ");
            double a119 = double.Parse(Console.ReadLine());

            Console.Write("Введите b: ");
            double b119 = double.Parse(Console.ReadLine());

            Console.Write("Введите c: ");
            double c119 = double.Parse(Console.ReadLine());

            Console.Write("Введите e: ");
            double e119 = double.Parse(Console.ReadLine());

            double x119 = Math.Sqrt((e119 - c119) / a119);

            Console.WriteLine("19 Задание. x = " + x119);

            ///

            Console.Write("Введите катет a: ");
            double a220 = double.Parse(Console.ReadLine());

            Console.Write("Введите катет b: ");
            double b220 = double.Parse(Console.ReadLine());

            double c220 = Math.Sqrt(a220 * a220 + b220 * b220);

            Console.WriteLine("20 Задание. Гипотенуза = " + c220);

            ///

            Console.Write("Введите внешний радиус: ");
            double R221 = double.Parse(Console.ReadLine());

            Console.Write("Введите внутренний радиус: ");
            double r221 = double.Parse(Console.ReadLine());

            double S221 = Math.PI * (R221 * R221 - r221 * r221);

            Console.WriteLine("21 Задание. Площадь = " + S221);

            ///

            Console.Write("Введите катет a: ");
            double a222 = double.Parse(Console.ReadLine());

            Console.Write("Введите катет b: ");
            double b222 = double.Parse(Console.ReadLine());

            double c222 = Math.Sqrt(a222 * a222 + b222 * b222);

            double P222 = a222 + b222 + c222;

            Console.WriteLine("22 Задание. Периметр = " + P222);

            ///

            Console.Write("Введите число a: ");
            double a223 = double.Parse(Console.ReadLine());

            Console.Write("Введите число b: ");
            double b223 = double.Parse(Console.ReadLine());

            double absA223 = Math.Abs(a223);
            double absB223 = Math.Abs(b223);

            double arithmetic223 = (absA223 + absB223) / 2;
            double geometric223 = Math.Sqrt(absA223 * absB223);

            Console.WriteLine("Среднее арифметическое = " + arithmetic223);
            Console.WriteLine("Среднее геометрическое = " + geometric223);

            ///

            int a224 = int.Parse(Console.ReadLine());

            int a24 = a * a;
            int a424 = a24 * a24;

            Console.WriteLine(a424);

            ///

            int a2245 = int.Parse(Console.ReadLine());

            int a2 = a * a;
            int a3 = a2 * a;
            int a6 = a3 * a3;

            Console.WriteLine(a6);

            ///

            int a2246 = int.Parse(Console.ReadLine());

            int a226 = a * a;
            int a326 = a226 * a;
            int a626 = a326 * a326;
            int a7 = a626 * a;

            Console.WriteLine(a7);

            ///

            int a2247 = int.Parse(Console.ReadLine());

            int a227 = a * a;
            int a4 = a227 * a227;
            int a8 = a4 * a4;

            Console.WriteLine(a8);

            ///

            int a2248 = int.Parse(Console.ReadLine());

            int a28 = a * a;
            int a38 = a28 * a;
            int a68 = a38 * a38;
            int a9 = a68 * a38;

            Console.WriteLine(a9);

            ///

            int a2249 = int.Parse(Console.ReadLine());

            int a29 = a * a;
            int a49 = a29 * a29;
            int a59 = a49 * a;
            int a10 = a59 * a59;

            Console.WriteLine(a10);

            ///

            Console.Write("Введите четырехзначное число: ");
            int n25 = int.Parse(Console.ReadLine());

            int a25 = n25 / 1000;
            int b25 = (n25 / 100) % 10;
            int c25 = (n25 / 10) % 10;
            int d25 = n25 % 10;

            int sum25 = a25 + b25 + c25 + d25;
            int mult25 = a25 * b25 * c25 * d25;

            Console.WriteLine("Задание 25. Сумма = " + sum25);
            Console.WriteLine("Произведение = " + mult25);

            ///

            int a26 = 2, b26 = 2, c26 = 2;

            double z26 = a26 * b26 + c26++ / b26 - a26 * b26 * --c26;

            Console.WriteLine("Задание 26", z26);
        }
    }
}
