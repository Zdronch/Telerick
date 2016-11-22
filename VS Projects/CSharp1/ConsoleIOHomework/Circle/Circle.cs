using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159265359;
            double P = 2 * (pi * r);
            double S = pi * r * r;
            Console.WriteLine("{0:0.00} {1:0.00}", P, S);
        }
    }
}
