using System;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double num1 = A;
            double num2 = B;

            if (A > B)
            {
                Console.WriteLine("{0} {1}", B, A);
            }
            else
            {
                Console.WriteLine("{0} {1}", A, B);
            }
        }
    }
}
