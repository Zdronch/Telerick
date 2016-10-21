using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double a = (double.Parse(Console.ReadLine()));
            double b = (double.Parse(Console.ReadLine()));

            if (Math.Abs(a - b) < 0.000001)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
