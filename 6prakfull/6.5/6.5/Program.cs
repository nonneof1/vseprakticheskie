//мне легче делать все в одном файле, ведь каждый раз создавать дополнительно 14 заданий слишком много времени занимает
namespace _6._5
{
    internal class Program
    {
        public static int sum;
        public static int count;

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(-20, 50);

            foreach (int x in arr)
                Console.Write(x + " ");
            Console.WriteLine();

            // 5.1
            int sumEvenIndex = 0;
            for (int i = 0; i < n; i += 2)
                sumEvenIndex += arr[i];
            Console.WriteLine("5.1: " + sumEvenIndex);

            // 5.2
            int minPos = int.MaxValue;
            foreach (int x in arr)
                if (x > 0 && x < minPos)
                    minPos = x;
            Console.WriteLine("5.2: " + minPos);

            // 5.3
            int max = arr[0], min = arr[0];
            foreach (int x in arr)
            {
                if (x > max) max = x;
                if (x < min) min = x;
            }
            Console.WriteLine("5.3: " + (max + min));

            // 5.4
            int countPos = 0;
            foreach (int x in arr)
                if (x > 0) countPos++;
            Console.WriteLine("5.4: " + countPos);

            // 5.5
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int sumSegment = 0;
            for (int i = a; i <= b; i++)
                sumSegment += arr[i];
            Console.WriteLine("5.5: " + sumSegment);

            // 5.6
            int sumEven = 0, countEven = 0;
            foreach (int x in arr)
            {
                if (x % 2 == 0)
                {
                    sumEven += x;
                    countEven++;
                }
            }
            Console.WriteLine("5.6: " + (countEven > 0 ? sumEven / countEven : 0));

            // 5.7
            int sumEvenPos = 0;
            foreach (int x in arr)
                if (x > 0 && x % 2 == 0)
                    sumEvenPos += x;
            Console.WriteLine("5.7: " + sumEvenPos);

            // 5.8
            int product = 1;
            for (int i = 0; i < n; i += 2)
                if (arr[i] >= 0)
                    product *= arr[i];
            Console.WriteLine("5.8: " + product);

            // 5.9
            max = arr[a];
            int indexMax = a;
            for (int i = a; i <= b; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    indexMax = i;
                }
            }
            Console.WriteLine($"5.9: max={max}, index={indexMax}");

            // 5.10
            min = arr[0];
            int indexMin = 0;
            for (int i = 0; i < n; i += 2)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    indexMin = i;
                }
            }
            Console.WriteLine($"5.10: min={min}, index={indexMin}");

            // 5.11
            min = arr[a];
            for (int i = a; i <= b; i++)
                if (arr[i] < min)
                    min = arr[i];
            Console.WriteLine("5.11: " + min);

            // 5.12
            sum = 0;
            count = 0;
            for (int i = 1; i < n; i += 2)
            {
                sum += arr[i];
                count++;
            }
            Console.WriteLine("5.12: " + (count > 0 ? sum / count : 0));

            // 5.13
            sum = 0;
            count = 0;
            foreach (int x in arr)
            {
                if (x % 2 != 0 && x < 50)
                {
                    sum += x;
                    count++;
                }
            }
            Console.WriteLine("5.13: " + (count > 0 ? sum / count : 0));

            // 5.14
            int[] evenIndex = new int[(n + 1) / 2];
            int[] oddIndex = new int[n / 2];

            int ei = 0, oi = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                    evenIndex[ei++] = arr[i];
                else
                    oddIndex[oi++] = arr[i];
            }

            // 5.15
            int[] oddElements = new int[n];
            int[] evenElements = new int[n];
            int o = 0, e = 0;

            foreach (int x in arr)
            {
                if (x % 2 != 0)
                    oddElements[o++] = x;
                else
                    evenElements[e++] = x;
            }
        }
    }
}

