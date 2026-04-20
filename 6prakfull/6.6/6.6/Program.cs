namespace _6._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < prices.Length; i++)
                prices[i] = rnd.Next(20, 301);

            int min = prices[0];
            int index = 0;

            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                    index = i;
                }
            }

            Console.WriteLine("Самый дешевый товар № " + index + " цена: " + min);
        }
    }
}
