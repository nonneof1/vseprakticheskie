
namespace _6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
             
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите M: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
