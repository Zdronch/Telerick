using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            string A = Console.ReadLine();
            int B = int.Parse(A);
            string C = (B % 35) == 0 ? "true " + B : "false " + B;
            Console.WriteLine(C);
        }
    }
}
