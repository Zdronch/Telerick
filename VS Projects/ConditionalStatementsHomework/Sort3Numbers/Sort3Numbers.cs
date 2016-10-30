using System;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {2} {1}", a, b, c);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine("{1} {0} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{1} {2} {0}", a, b, c);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine("{2} {0} {1}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{2} {1} {0}", a, b, c);
                }
            }
        }
    }
}
