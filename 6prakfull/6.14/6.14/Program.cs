namespace _6._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int[] result = new int[n / 4];
            Array.Copy(arr, n - n / 4, result, 0, n / 4);
        }
    }
}
