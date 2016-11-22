using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            string num = Console.ReadLine();
            int num1 = Int32.Parse(num);
            string gg = (num1 & 1) == 0 ? "even" : "odd";
            Console.WriteLine((gg == "even") ? "even " + num1 : "odd " + num1);
        }
    }
}
