﻿using System;

namespace NumbersComparer
{
    class NumbersComparer
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine((A >= B)? A : B);
        }
    }
}
