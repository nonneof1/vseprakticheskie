namespace _6._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int count = 0;
            while (count < arr.Length && arr[count] >= 20)
                count++;

            int[] result = new int[arr.Length - count];
            Array.Copy(arr, count, result, 0, result.Length);
        }
    }
}
