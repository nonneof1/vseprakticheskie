namespace _6._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int[] result = new int[4];
            Array.Copy(arr, 6, result, 0, 4);
        }
    }
}
