namespace _6._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 45, 9, 87 };

            // по сумме цифр
            Array.Sort(arr, (a, b) =>
            {
                int Sum(int x) => x.ToString().Sum(c => c - '0');
                return Sum(a).CompareTo(Sum(b));
            });

            // по последней цифре
            Array.Sort(arr, (a, b) => (a % 10).CompareTo(b % 10));

            // по первой цифре
            Array.Sort(arr, (a, b) =>
            {
                int First(int x) => int.Parse(x.ToString()[0].ToString());
                return First(a).CompareTo(First(b));
            });
        }
    }
}