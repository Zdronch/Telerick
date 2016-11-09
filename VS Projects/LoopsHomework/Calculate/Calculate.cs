using System;

namespace Calculate
{
    class Calculate
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double rezult = 1.00;
            double FaktSum = 1.00;
            double tempDelitel = 1.00;
            for (int i = 1; i <= N; i++)
            {
                // double factorial = 0.0;
                FaktSum *= i;
                tempDelitel = tempDelitel * N;
                rezult += FaktSum / tempDelitel;

            }

            Console.WriteLine(rezult);
        }
    }
}
