using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            if (N <= 1)
            {
                Console.WriteLine("false");
            }
            else if (N > 1 && N <= 100)
            {
                if (N == 2 || N == 3 || N == 5 || N == 7)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    if (N % 2 != 0 && N % 3 != 0 && N % 5 != 0 && N % 7 != 0)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
