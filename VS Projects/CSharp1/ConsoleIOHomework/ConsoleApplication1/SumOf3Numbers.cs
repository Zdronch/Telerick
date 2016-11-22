using System;

namespace ConsoleApplication1
{
    class SumOf3Numbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double num1 = Convert.ToDouble(a);
            double num2 = Convert.ToDouble(b);
            double num3 = Convert.ToDouble(c);

            Console.WriteLine(num1 + num2 + num3);
        }
    }
}
