using System;

namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());
            decimal num = (x - 0) * (x - 0) + (y - 0) * (y - 0);
            bool isInsideCirle = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= 2 * 2 ? true : false;
            Console.WriteLine((isInsideCirle == true) ? "yes " + num : "no " + num);
        }
    }
}
