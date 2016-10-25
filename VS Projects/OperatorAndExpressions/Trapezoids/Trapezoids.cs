using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double S = (0.5 * (a + b) * h);
            string str = S.ToString("F7");
            Console.WriteLine(str);
        }
    }
}
