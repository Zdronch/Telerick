using System;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)))
            {
                Console.WriteLine("inside circle " + "inside rectangle");
            }
            else if (((x - 1) * (x - 1) + (y - 1) * (y - 1) > 1.5 * 1.5) && ((x >= -1 && x <= 5) && (y <= 1 && y >= -1)))
            {
                Console.WriteLine("outside circle " + "inside rectangle");
            }
            else if (((x - 1) * (x - 1) + (y - 1) * (y - 1) <= 1.5 * 1.5) && ((x < -1 && x > 5) && (y > 1 && y < -1)))
            {
                Console.WriteLine("inside circle " + "outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle " + "outside rectangle");
            }
        }
    }
}
