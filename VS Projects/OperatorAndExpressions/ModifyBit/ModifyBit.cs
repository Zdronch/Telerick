using System;

namespace ModifyBit
{
    class ModifyBit
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            if (v == 1)
            {
                int setOne = 1 << P;
                int foundBitOne = N | setOne;
                Console.WriteLine(foundBitOne);
            }
            else
            {
                int setZero = ~(1 << P);
                int foundBitZero = N & setZero;
                Console.WriteLine(foundBitZero);
            }
        }
    }
}
