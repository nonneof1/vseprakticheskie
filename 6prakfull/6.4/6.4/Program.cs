namespace _6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[17];
            double sum = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите число: ");
                arr[i] = int.Parse(Console.ReadLine());

                if (arr[i] > 0 && arr[i] % 2 != 0)
                {
                    sum += arr[i];
                    count++;
                }
            }

            Console.WriteLine("Среднее: " + (count > 0 ? sum / count : 0));
        }
    }
}
