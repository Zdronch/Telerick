using System;

namespace NthBit
{
    class NthBit
    {
        static void Main()
        {
            int P = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine((P >> N) & 1);
        }
    }
}
