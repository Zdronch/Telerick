using System;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            decimal sum = 0m;
            decimal number = decimal.MinValue;

            for (int i = 1; i <= N; ++i)
            {
                number = decimal.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
