namespace _6._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 9, 1 };

            //пузырек
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);

            //выбор
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] < arr[min]) min = j;

                (arr[i], arr[min]) = (arr[min], arr[i]);
            };
            //встроенная
            Array.Sort(arr);
        }
    }
}
