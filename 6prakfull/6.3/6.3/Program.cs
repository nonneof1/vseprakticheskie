namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите число: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Отрицательные элементы на четных индексах:");
            for (int i = 0; i < arr.Length; i += 2)
            {
                if (arr[i] < 0)
                    Console.Write(arr[i] + " ");
            }
        }
    }
}
