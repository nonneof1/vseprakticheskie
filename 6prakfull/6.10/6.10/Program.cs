namespace _6._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            bool hasPositive = false;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] > 0)
                    hasPositive = true;
            }

            Console.WriteLine(hasPositive);
        }
    }
}
