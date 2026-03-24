namespace _6._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
