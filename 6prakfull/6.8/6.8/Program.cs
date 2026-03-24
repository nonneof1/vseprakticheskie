namespace _6._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool allPositive = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] <= 0)
                    allPositive = false;
            }

            Console.WriteLine(allPositive);
        }
    }
}
