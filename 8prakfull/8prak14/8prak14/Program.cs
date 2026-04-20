namespace _8prak14
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string pass = "";
            for (int i = 0; i < 8; i++)
                pass += chars[rnd.Next(chars.Length)];

            Console.WriteLine(pass);
        }
    }
}