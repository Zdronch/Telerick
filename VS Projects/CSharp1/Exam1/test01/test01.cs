using System;

namespace test01
{
    class test01
    {
        static void Main()
        {
            decimal birds = decimal.Parse(Console.ReadLine());
            decimal feathers = decimal.Parse(Console.ReadLine());
            decimal avg = feathers / birds;
            decimal oddavg = avg / 317;
            decimal evenavg = avg * 123123123123;

            if (birds % 2 != 0)
            {
                Console.WriteLine("{0:F4}", oddavg);
            }
            else
            {
                Console.WriteLine("{0:F4}", evenavg);
            }
        }
    }
}
