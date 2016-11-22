using System;

namespace test2
{
    class test2
    {
        static void Main()
        {
            int busses = int.Parse(Console.ReadLine());
            int maxSpeed = 1500;
            int groups = 0;

            for (int i = 1; i <= busses; i++)
            {
                int speed = int.Parse(Console.ReadLine());
                if (speed <= maxSpeed)
                {
                    groups++;
                    maxSpeed = speed;
                }
                
            }
            Console.WriteLine(groups);
        }
    }
}
