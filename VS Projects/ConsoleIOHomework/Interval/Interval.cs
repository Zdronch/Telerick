using System;

namespace Interval
{
    class Interval
    {
        static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
