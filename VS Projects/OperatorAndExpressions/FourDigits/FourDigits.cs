﻿using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number - a * 1000) / 100;
            int c = (number - (a * 1000 + b * 100)) / 10;
            int d = (number - (a * 1000 + b * 100 + c * 10));
            int sum = a + b + c + d;
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
