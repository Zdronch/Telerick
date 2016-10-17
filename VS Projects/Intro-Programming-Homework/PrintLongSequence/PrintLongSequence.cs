using System;

namespace PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main()
        {
            int count = 2;
            for (int i = count; i <= 1001; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 != 0)

                {
                    Console.WriteLine("-" + i);
                }
        }
    }
}
