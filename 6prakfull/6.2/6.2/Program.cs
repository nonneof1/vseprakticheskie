namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[8];
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите число: ");
                arr[i] = double.Parse(Console.ReadLine());

                if (arr[i] > 0)
                {
                    sum += arr[i];
                    count++;
                }
            }

            Console.WriteLine("Среднее положительных: " + (count > 0 ? sum / count : 0));
        }
    }
}
