using System;

namespace PrintAscii
{
    class PrintAscii
    {
        static void Main()
        {
            int count = 33;
            for (int i = count; i <= 126; i++)
            Console.Write((char)i);
        }
    }
}
