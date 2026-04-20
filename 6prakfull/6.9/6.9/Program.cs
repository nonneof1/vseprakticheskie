namespace _6._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool allEven = true;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 != 0)
                    allEven = false;
            }

            Console.WriteLine(allEven);
        }
    }
}
