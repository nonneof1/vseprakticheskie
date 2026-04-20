namespace _6._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
                arr[i] = int.Parse(Console.ReadLine());

            int count = 0;
            foreach (int x in arr)
                if (x % 2 != 0)
                    count++;

            int[] result = new int[count];
            int j = 0;

            foreach (int x in arr)
                if (x % 2 != 0)
                    result[j++] = x;
        }
    }
}
