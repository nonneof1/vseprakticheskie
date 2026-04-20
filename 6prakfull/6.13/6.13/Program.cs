namespace _6._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(-50, 50);
            //foreach (int x in arr)
                //Console.Write(x + " ");
        }
    }
}
