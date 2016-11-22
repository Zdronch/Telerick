using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double D = (b * b) - (4*a*c);
            double root1 = ((-b) - Math.Sqrt(D)) / (2 * a);
            double root2 = ((-b) + Math.Sqrt(D)) / (2 * a);

            if ((D > 0) && (root1 < root2))
            {
                Console.WriteLine("{0:0.00}\n{1:0.00}", root1, root2);
            }
            else if (D == 0)
            {
                Console.WriteLine("{0:0.00}", root1);
            }
            else
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}
