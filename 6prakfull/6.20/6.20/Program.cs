namespace _6._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Reverse(arr);

            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
