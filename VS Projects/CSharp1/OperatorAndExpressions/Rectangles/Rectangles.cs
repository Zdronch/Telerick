using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double a = (double.Parse(Console.ReadLine()));
            double b = (double.Parse(Console.ReadLine()));
            double area = (a * b);
            double perimeter = (a + b) * 2;
            string area1 = area.ToString("F2");
            string perimeter1 = perimeter.ToString("F2");
            string both = (area1 + " " + perimeter1);
            Console.WriteLine(both);
        }
    }
}
