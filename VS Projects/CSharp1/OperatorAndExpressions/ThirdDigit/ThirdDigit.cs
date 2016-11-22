using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = (a / 100);
            int c = (b % 10);
            Console.WriteLine((c == 7) ? "true" : "false " + c);
        }
    }
}
