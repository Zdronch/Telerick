using System;

namespace _3rdBit
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine((a >> 3) & 1);
        }
    }
}
