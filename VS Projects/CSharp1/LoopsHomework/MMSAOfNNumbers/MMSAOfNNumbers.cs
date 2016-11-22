using System;

namespace MMSAOfNNumbers
{
    class MMSAOfNNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double min = 10000;
            double max = -10000;
            double sum = 0;
            double avg = 0;

            for (int i = 1; i <= N; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
                avg = sum / N;
                min = Math.Min(min, num);
                max = Math.Max(max, num);
            }
            Console.WriteLine("min={0:0.00}", min);
            Console.WriteLine("max={0:0.00}", max);
            Console.WriteLine("sum={0:0.00}", sum);
            Console.WriteLine("avg={0:0.00}", avg);
        }
    }
}
