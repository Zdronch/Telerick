using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            string W = Console.ReadLine();
            decimal Wei = decimal.Parse(W);
            decimal Weight = (Wei / 100) * 17;
            string str = Weight.ToString("F3");
            Console.WriteLine(str);
        }
    }
}
