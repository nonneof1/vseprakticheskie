namespace _6._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 100);
            //если нужен вывод
            //foreach (int x in arr)
                //Console.Write(x + " ");
        }
    }
}
