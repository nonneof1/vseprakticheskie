namespace _6._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArr = { 1, 2, 3, 4, 5 };
            int[] mArr = { 3, 4, 5, 6, 7 };

            //19.1
            var res1 = nArr.Where(x => !mArr.Contains(x)).ToArray();

            //19.2
            var res2 = nArr.Where(x => !mArr.Contains(x))
                .Concat(mArr.Where(x => !nArr.Contains(x))).ToArray();

            //19.3
            var res3 = nArr.Union(mArr).ToArray();
        }
    }
}
