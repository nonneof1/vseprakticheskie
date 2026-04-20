namespace _6._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int i2 = 0;
            while (i2 < arr.Length && arr[i2] < 20)
                i2++;

            int[] result = new int[arr.Length - i2];
            Array.Copy(arr, i2, result, 0, result.Length);
        }
    }
}
