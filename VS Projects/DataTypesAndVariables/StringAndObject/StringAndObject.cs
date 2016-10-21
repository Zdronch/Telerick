using System;

namespace StringAndObject
{
    class StringAndObject
    {
        static void Main()
        {
            string n1 = "Hello ";
            string n2 = "World";
            object gg = n1 + n2;
            string n3 = (string)gg;
            Console.WriteLine(n3);
        }
    }
}
